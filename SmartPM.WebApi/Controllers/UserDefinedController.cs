using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartPM.Business.Models;
using SmartPM.Business.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartPM.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserDefinedController : Controller
    {
        UserDefinedRepository userDefinedRepo;

        public UserDefinedController()
        {
            userDefinedRepo = new UserDefinedRepository();
        }

        [HttpPost]
        public IEnumerable<M_UserDefined> GetUserDefined(string category, string key)
        {
            var result = userDefinedRepo.GetUserDefined(category, key);
            return result;
        }

        [HttpPost]
        public void AddUserDefined(M_UserDefined userDefined)
        {
            userDefinedRepo.AddUserDefined(userDefined);
        }

        [HttpPost]
        public void UpdateUserDefined(M_UserDefined userDefined)
        {
            userDefinedRepo.UpdateUserDefined(userDefined);
        }

        [HttpPost]
        public void DeleteUserDefined(int id)
        {
            userDefinedRepo.DeleteUserDefined(id);
        }

    }
}
