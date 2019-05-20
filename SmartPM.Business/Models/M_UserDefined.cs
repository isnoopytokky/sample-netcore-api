using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_UserDefined
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string KeyID { get; set; }
        public string Value { get; set; }
        public string Value_2 { get; set; }
        public string Value_3 { get; set; }
        public bool IsActive { get; set; }
        public string Remark { get; set; }
    }
}
