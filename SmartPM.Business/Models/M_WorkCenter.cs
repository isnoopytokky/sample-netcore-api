using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_WorkCenter
    {
        public int WorkCenterID { get; set; }
        public string WorkCenterCode { get; set; }
        public string WorkCenterName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
