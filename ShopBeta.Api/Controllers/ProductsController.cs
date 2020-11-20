using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;
        public ProductsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts(bool withReviews=false)
        {

            try
            {
                if (withReviews == false)
                {

                    var products = await _repository.Products.GetAllProductsAsync(trackChanges: false);
                    if (products == null)
                    {
                        _logger.LogInfo("No products were found");
                        return NoContent();
                    }

                    //var productDto = _mapper.Map<ProductsDto>(products);


                    return Ok(products);
                }
                else
                {
                     var productsWithReviews = await _repository.Products.GetAllProductsWithReviewsAsync(trackChanges: false);
                    if(productsWithReviews == null)
                    {
                        _logger.LogInfo("no products were found.");
                        return NoContent();
                    }

                    //var productsDto = _mapper.Map<ProductsDto>(productsWithReviews);

                    return Ok(productsWithReviews);
                }
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

        [Authorize(Roles = "Admin,Seller")]
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

                //gets the instance of the logged in user
                ClaimsPrincipal user = this.User;
               
                string Store = user.Claims.Where(c => c.Type == "Store")
                   .Select(x => x.Value).FirstOrDefault();

                string seller = user.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
                    .Select(x => x.Value).FirstOrDefault();



                var product = _mapper.Map<Products>(productDto);

                product.SellerId = seller;
                product.Store = Store;

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
        [Authorize(Roles = "Admin,Seller")]

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

        [Authorize(Roles ="Admin,Customer")]
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

        [Authorize(Roles = "Admin,Customer")]
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
