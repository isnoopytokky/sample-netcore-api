using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_Plant
    {
        public int PlantID { get; set; }
        public string PlantCode { get; set; }
        public string PlantName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
