using Pizzeria.BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Core.Interfaces
{
    public interface ILogin
    {
        bool Login(LoginModel login);
    }
}
