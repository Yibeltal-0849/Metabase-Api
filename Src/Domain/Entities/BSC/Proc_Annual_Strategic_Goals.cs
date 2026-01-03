using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_Annual_Strategic_Goals
    {
		public string Annual_Strategic_GoalID { get; set; }
		public string Strategic_ThemeID { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public int? Year { get; set; }
		public double? Result_In_Per { get; set; }
		public System.Guid? ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string DocNo { get; set; }
		public string Log { get; set; }
		public bool? IsActive { get; set; }
	}
}
