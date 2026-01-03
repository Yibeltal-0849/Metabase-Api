using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOKA.WebUI.Model
{
    public class Organizational_Structure
    {
        public Guid? Structure_ID { get; set; }
        public Guid? DIV { get; set; }
        public Guid? Job_Position { get; set; }
        public string RoleName { get; set; }
        public string Eductional_Criteria { get; set; }
        public string Experiance_Criteria { get; set; }
        public string Training_Criteria { get; set; }
        public int? Addtional_Empolye_Needed { get; set; }
        //public double Basic_Salary { get; set; }
        //public double? OT_Amount { get; set; }
        //public string Provision { get; set; }
        public bool? Is_Active { get; set; }
        public string Remark { get; set; }
    }
}
