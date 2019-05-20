using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_PlannerGroup
    {
        public int PlannerGroupId { get; set; }
        public string PlannerGroupCode { get; set; }
        public string PlannerGroupName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
