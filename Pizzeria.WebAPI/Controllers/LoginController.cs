using Microsoft.AspNetCore.Mvc;
using Pizzeria.BusinessEntities.Entities;
using Pizzeria.Core.Interfaces;

namespace Pizzeria.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _loginService;
        public LoginController(ILogin login)
        {
            _loginService = login;
        }

        [HttpPost("Signin")]
        public bool Login(LoginModel login)
        {
            return _loginService.Login(login);
        }
    }
}
