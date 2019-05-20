using SmartPM.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.WebApi.Models
{
    interface IUserService
    {
        M_User Authenticate(string username, string password);
        IEnumerable<M_User> GetAll();
    }
}
