using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface IAuthService
    {
         Task<AuthModel>  RegisterAsync(RegisterModel model);
        Task<AuthModel> LoginAsync(LoginModel model);


    }
}
