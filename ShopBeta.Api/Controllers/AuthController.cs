using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.Models;
using ShopBeta.Infrastructure.Authentication;

namespace ShopBeta.Api.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authenticationManager;


        public AuthController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IAuthenticationManager authenticationManager)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _authenticationManager = authenticationManager ?? throw new ArgumentNullException(nameof(authenticationManager));
        }


        [HttpPost]
        public async Task<IActionResult> Registeration([FromBody] UserRegistrationDto userRegistration)
        {
            try 
            {
                if (!ModelState.IsValid)
                {
                    return UnprocessableEntity();
                }

                var user = _mapper.Map<User>(userRegistration);
                var result = await _userManager.CreateAsync(user, userRegistration.Password);


                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.TryAddModelError(error.Code, error.Description);
                    }

                    return BadRequest(ModelState);
                }

             
                await _userManager.AddToRolesAsync(user, userRegistration.Roles);

                return StatusCode(201);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login ([FromBody] UserAuthenticationDto userAuthentication)
        {
            try
            {
                var user = await _authenticationManager.ValidateUser(userAuthentication);

                if (!user)
                {
                    _logger.LogWarn($"{nameof(Login)}: Authentication failed. Wrong username or password.");
                    return Unauthorized();
                }

               return  Ok(new { Token = await _authenticationManager.CreateToken() });
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                return StatusCode(500);
            }
            
        }
    }
}
