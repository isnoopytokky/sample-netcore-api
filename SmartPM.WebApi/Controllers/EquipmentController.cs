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
    public class EquipmentController : Controller
    {
        EquipmentRepository eqRepo;

        public EquipmentController()
        {
            eqRepo = new EquipmentRepository();
        }

        [HttpPost]
        public IEnumerable<M_Equipment> GetEQ(string eqCode,string eqName)
        {
            var result=eqRepo.GetEQ(eqCode,eqName);
            return result;
        }

        [HttpPost]
        public void AddEQ(M_Equipment eq)
        {
            eqRepo.AddEQ(eq);
        }

        [HttpPost]
        public void UpdateEQ(M_Equipment eq)
        {
            eqRepo.UpdateEQ(eq);
        }

        [HttpPost]
        public void DeleteEQ(string eq_code)
        {
            eqRepo.DeleteEQ(eq_code);
        }

    }
}
