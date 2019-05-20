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
    public class PlantController : Controller
    {
        PlantRepository plantRepo;

        public PlantController()
        {
            plantRepo = new PlantRepository();
        }

        [HttpGet]
        [HttpPost]
        [Route("GetPlant")]
        public IEnumerable<M_Plant> GetPlant()
        {
            var result = plantRepo.GetPlant();
            return result;
        }

        [HttpPost]
        public void AddPlant(M_Plant plant)
        {
            plantRepo.AddPlant(plant);
        }

        [HttpPost]
        public void UpdatePlant(M_Plant plant)
        {
            plantRepo.UpdatePlant(plant);
        }

        [HttpPost]
        public void DeletePlant(int plant_id)
        {
            plantRepo.DeletePlant(plant_id);
        }
    }
}
