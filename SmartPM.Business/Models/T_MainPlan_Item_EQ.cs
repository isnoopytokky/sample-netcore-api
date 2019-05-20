using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class T_MainPlan_Item_EQ
    {
        public Int64 PlanItemEQID { get; set; }
        public int PlanItemID { get; set; }
        public string EQCode { get; set; }
        public string LocationCode { get; set; }
        public string PlannerGroupCode { get; set; }
        public string WorkCenterCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
