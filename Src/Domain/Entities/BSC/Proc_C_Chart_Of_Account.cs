using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_C_Chart_Of_Account
    {
		public string Account_ID{ get; set; }
		public string Org_ID{ get; set; }
		public string Description{ get; set; }
		public long? Account_Type{ get; set; }
		public System.Guid? Branch{ get; set; }
		public System.Guid? DIV { get; set; }
		public bool? Blocked{ get; set; }
		public string Parent{ get; set; }
		public string Propose_Type{ get; set; }
		public double? Totaling{ get; set; }
		public bool? Direct_Posting{ get; set; }
		public bool? Is_Debit { get; set; }
		public bool? Is_Credit { get; set; }
		public string Gen_Posting_Type{ get; set; }
		public string Gen_Bus_Posting_Group{ get; set; }
		public string TAX_Bus_Posting_Group{ get; set; }
		public string TAX_Prod_Posting_Group{ get; set; }
		public string Gen_Prod_Posting_Group{ get; set; }
		public string Default_IC_Partner_G_L_Acc_No{ get; set; }
		public bool? Is_Balance_Sheet { get; set; }
		public System.DateTime? Last_Date_Modified { get; set; }
	}
}
