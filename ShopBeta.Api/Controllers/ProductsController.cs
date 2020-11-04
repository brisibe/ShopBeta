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
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
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

        [HttpGet("{ProductId}", Name = "ProductbyId")]

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
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreationDto productDto)
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
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "internal server error");

            }
        }

        [HttpDelete("{productId}")]

        public async Task<IActionResult> DeleteProduct(int productId)
        {
            try
            {
                var product = await _repository.Products.GetProductAsync(productId, trackChanges: false);

                if (product == null)
                {
                    _logger.LogError($"product with id {productId} was not found");
                    return NotFound();
                }

                _repository.Products.DeleteProduct(product);
                await _repository.SaveAsync();

                return NoContent();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);

            }
        }

        [HttpGet("{productId}/reviews")]
        public async Task<IActionResult> GetProductReviews(int productId)
        {
            try
            {
                var productReviews = await _repository.Reviews.GetReviews(productId, trackChanges: false);
                if (productReviews == null)
                {
                    _logger.LogInfo("there are no reviews for this product");
                    return NotFound();
                }

                return Ok(productReviews);


            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpPost("{productId}/reviews")]
        public async Task<IActionResult> CreateReview (int productId, ReviewsDto review)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogError("invalid model");
                    return UnprocessableEntity();
                }

                var product = await _repository.Products.GetProductAsync(productId, trackChanges: false);

                if (product == null)
                {
                    _logger.LogInfo($"product with id: {productId} doesnt exist");
                    return NotFound();
                }
                

                var reviewEntity = _mapper.Map<Reviews>(review);

                reviewEntity.ProductId = productId;



                _repository.Reviews.CreateReview(reviewEntity);
                await _repository.SaveAsync();

                return NoContent();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpDelete("{productId}/reviews/{reviewId}")]
        public async Task<IActionResult> DeleteReview(int productId,int reviewId)
        {
            try
            {
               
                var product = await _repository.Products.GetProductAsync(productId, trackChanges: false);

                if (product == null)
                {
                    _logger.LogInfo($"product with id: {productId} doesnt exist");
                    return NotFound();
                }

                var reviewEntity = await _repository.Reviews.GetReview(productId, reviewId, trackChanges:false);


                _repository.Reviews.DeleteReview(reviewEntity); 
                await _repository.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
