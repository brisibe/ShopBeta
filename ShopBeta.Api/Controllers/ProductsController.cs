using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopBeta.Core.DTO.Response;
using ShopBeta.Core.Entities.Requests;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.Models;

namespace ShopBeta.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public ProductsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(_logger)); 
            _repository = repository?? throw new ArgumentNullException(nameof(_repository));
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {

            try
            {
             
                var products = await _repository.Products.GetAllProductsAsync(trackChanges: false);
                if (products == null)
                {
                    _logger.LogInfo("No products where found");
                    return NoContent();
                }

                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "something went wrong, internal server error");
            }
        }

        [HttpGet("{ProductId}", Name ="ProductbyId")]

        public async Task<IActionResult> GetProductById(int productId)
        {
            try
            {
                var product = await _repository.Products.GetProductAsync(productId, trackChanges: false);
                var reviews = await _repository.Reviews.GetReviews(productId, trackChanges: false);

                if (product == null)
                {
                    _logger.LogInfo($"Product with the id:{productId} doesnt exist");
                    return NotFound();
                }

             

                return Ok(product);
                

              
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Something went wrong, internal server error");
            }

        }

        [HttpPost]
        public async Task <IActionResult> CreateProduct([FromBody] ProductCreationDto productDto)
        {
            try
            {
                if (productDto == null)
                {
                    _logger.LogError("product sent from client is empty");
                    return BadRequest("product object is empty");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("invalid model state for product");
                    return UnprocessableEntity();
                }

                var product = _mapper.Map<Products>(productDto);   //TOdO: fix automapper problem

                _repository.Products.CreateProduct(product);
                await _repository.SaveAsync();

                return CreatedAtRoute("ProductById", new { ProductId = product.ProductsId }, product);
                    
                    }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "internal server error");

            }
        }

    }
}
