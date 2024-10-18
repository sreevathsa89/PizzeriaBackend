using Pizzeria.BusinessEntities.Entities;
using Pizzeria.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Core.Services
{
    public class LoginService : ILogin
    {
        public bool Login(LoginModel login)
        {

            if(login.UserName != null &&  login.Password != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
