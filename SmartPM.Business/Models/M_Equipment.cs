using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_Equipment
    {
        public Int64 EQID { get; set; }
        public string EQCode { get; set; }
        public string EQName { get; set; }
        public string LocationCode { get; set; }
        public string PlannerGroupCode { get; set; }
        public string WorkCenterCode { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
