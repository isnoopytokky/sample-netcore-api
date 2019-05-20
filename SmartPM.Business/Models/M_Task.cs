using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_Task
    {
        public int TaskID { get; set; }
        public int TaskGroupID { get; set; }
        public string TaskName { get; set; }
        public int Seq { get; set; }
        public bool IsDeleted { get; set; }
    }
}
