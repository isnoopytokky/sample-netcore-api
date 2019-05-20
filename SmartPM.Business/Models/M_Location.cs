using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
   public class M_Location
    {
        public int LocationId { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string PlantCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
