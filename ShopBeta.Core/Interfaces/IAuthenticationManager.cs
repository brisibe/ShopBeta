using ShopBeta.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Core.Interfaces
{
   public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserAuthenticationDto userrAuth);
        Task<string> CreateToken();
    }
}
