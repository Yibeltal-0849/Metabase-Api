using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_Annual_Strategic_Plan_Assignment2
    {
		public System.Guid? ASPA_ID { get; set; }
		public string ASGD_ID { get; set; }
		public System.Guid? Assigned_Body { get; set; }
		public System.Guid? Responsible_Role { get; set; }
		public bool? Is_Active { get; set; }
		public System.Guid? ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public System.Guid? Assigned_By { get; set; }
	}
}
