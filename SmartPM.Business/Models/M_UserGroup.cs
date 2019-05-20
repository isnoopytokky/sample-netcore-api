using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPM.Business.Models
{
    public class M_UserGroup
    {
        public int UserGroupID { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
