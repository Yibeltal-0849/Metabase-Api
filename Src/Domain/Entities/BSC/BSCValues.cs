
using System;

namespace XOKA.Domain.Entities.Bsc
{
    public class BSCValues
	{
		public System.Guid BSC_Value_ID { get; set; }
		public System.Guid? BSC_Tran_ID { get; set; }
		public System.Guid KPIMapping_ID { get; set; }
		public System.Guid KPI_ID { get; set; }
		public string Performance_Indicator { get; set; }
		public string Period { get; set; }
		public System.DateTime Start_Date { get; set; }
		public System.DateTime End_Date { get; set; }
		public string Unit { get; set; }
		public System.Double? Value { get; set; }
		public string Remark { get; set; }
		public string User_Name { get; set; }
		public System.Guid? User_ID { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Update_Date { get; set; }

	}
}
