using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopBeta.Core.DTO.Requests;
using ShopBeta.Core.DTO.Response;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.Models;
using ShopBeta.Infrastructure.Repository;

namespace ShopBeta.Api.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        
        public OrdersController(ILoggerManager logger, UserManager<User> userManager, IRepositoryManager repository, IMapper mapper)
        {
            _Logger = logger;
            _userManager = userManager;
            _repository = repository;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]

        [HttpGet]
        public async Task<IActionResult> GetOrders(bool includeItems=false)
        {
            try
            {
                var orders = await _repository.Orders.GetOrdersAsync(includeItems, trackChanges: false);

                
                

                if(orders == null)
                {
                    _Logger.LogInfo("No orders where found");
                    return NoContent();
                }

                var orderDto = _mapper.Map<OrderDto>(orders);

                return Ok(orderDto);
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex.Message);
                return StatusCode(500);

            }
        }

        [Authorize(Roles ="Admin")]
        [HttpGet("{orderNumber}", Name = "OrderByNumber")]
        public async Task<IActionResult> GetOrdersByOrderNumber(int orderNumber)
        {
            try
            {
                var order = await _repository.Orders.GetOrdersByOrderNumberAsync(orderNumber, trackChanges: false);
                if(order == null)
                {
                    _Logger.LogInfo($"order with id {orderNumber} does not exist.");
                    return NoContent();
                }

                var orderDto = _mapper.Map<OrderDto>(order);

                return Ok(orderDto);
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }

        [Authorize(Roles = "Customer, Admin")]

        [HttpPost]
        public async Task<IActionResult> CreateOrder ([FromBody] OrderCreationDto orderDto)
        {
            if(orderDto == null)
            {
                _Logger.LogError("order is empty");
                return BadRequest();
            }


            try
            {
                //gets phone number and address from claims of the currently logged in user 
                ClaimsPrincipal customer = this.User;
                var phoneNumber = customer.Claims.Where(c => c.Type == "PhoneNumber")
                    .Select(c => c.Value).FirstOrDefault();

                var Address = customer.Claims.Where(c => c.Type == "Address")
                   .Select(c => c.Value).FirstOrDefault();

                var order = _mapper.Map<Order>(orderDto);

                order.phone = phoneNumber;
                order.ShippingAddress = Address;


                _repository.Orders.CreateOrder(order);

                await _repository.SaveAsync();


                var orderCreated = _mapper.Map<OrderDto>(order);

                return CreatedAtRoute("OrderByNumber", new { orderNumber = order.OrderNumber }, orderCreated);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ex.Message);
                return StatusCode(500);
            }



        }

        [Authorize(Roles = "Admin")]

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int orderNumber)
        {
            try
            {
                var order = await _repository.Orders.GetOrdersByOrderNumberAsync(orderNumber, trackChanges: false);
                
                if(order == null)
                {
                    _Logger.LogInfo($"order number {orderNumber} does not exist.");

                    return BadRequest();
                }

                _repository.Orders.DeleteOrder(order);

                await _repository.SaveAsync();

                return NoContent();

            }
            catch(Exception ex)
            {
                _Logger.LogError(ex.Message);
                return StatusCode(500);
            }

        }

    }
}
