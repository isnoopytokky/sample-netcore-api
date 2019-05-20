using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class T_MainPlan_Item
    {
        public int PlanItemID { get; set; }
        public string PlanCode { get; set; }
        public int Cycle { get; set; }
        public string CycleUnit { get; set; }
        public int TaskGroupID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
