﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.DTO;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopBeta.Infrastructure.Authentication;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace ShopBeta.Infrastructure.auth
{

        public class AuthenticationManager : IAuthenticationManager
        {
            private readonly UserManager<User> _userManager;
            private readonly IConfiguration _configuration;
            private User _user;

            public AuthenticationManager(UserManager<User> userManager, IConfiguration configuration)
            {
                _userManager = userManager;
                _configuration = configuration;
            }

            public async Task<bool> ValidateUser(UserAuthenticationDto userAuth)
            {

                _user = await _userManager.FindByNameAsync(userAuth.UserName);

                return (_user != null && await _userManager.CheckPasswordAsync(_user, userAuth.Password));
            }

            public async Task<string> CreateToken()
            {

                var signingCredentials = GetSigningCredentials();
                var claims = await GetClaims();
                var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
                return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            }


            private SigningCredentials GetSigningCredentials()
            {
                var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
                var secret = new SymmetricSecurityKey(key);
                return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
            }

            private async Task<List<Claim>> GetClaims()
            {
            var claims = new List<Claim> {

                new Claim(ClaimTypes.Name, _user.UserName),
                new Claim("Email", _user.Email),
                new Claim("sub", _user.Id),
                new Claim("PhoneNumber", _user.PhoneNumber),
                new Claim("Address", _user.Address),
                new Claim("Store", _user.Store)
                

            };

                var roles = await _userManager.GetRolesAsync(_user);

                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
                return claims;
            }

            private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
            {
                var jwtSettings = _configuration.GetSection("JwtSettings");

                var tokenOptions = new JwtSecurityToken
                    (
                    issuer: jwtSettings.GetSection("validIssuer").Value,
                    audience: jwtSettings.GetSection("validAudience").Value,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
                    signingCredentials: signingCredentials

                    );

                return tokenOptions;
            }

     
        }
    }

