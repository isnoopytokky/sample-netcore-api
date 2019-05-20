using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
   public class T_MainPlan_Header
    {
        public int PlanID { get; set; }
        public string PlanCode { get; set; }
        public string Plant { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Awake { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
