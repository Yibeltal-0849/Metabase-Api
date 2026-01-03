namespace XOKA.Domain.Entities.HRA
{
    public class LeaveTransaction
    {
		public System.Guid Leave_Tran_ID { get; set; }
		public System.Guid? Application_Code { get; set; }
		public string Application_NO { get; set; }
		public System.Guid? Service_Code { get; set; }
		public string Service_Name { get; set; }
		public string Employee_ID { get; set; }
		public bool? With_Salary { get; set; }
		public bool? With_Out_Salary { get; set; }
		public System.Guid? Leave_Type { get; set; }
		public System.DateTime? Leave_From_Start_Date { get; set; }
		public System.DateTime? Leave_End_Date { get; set; }
		public string? Leave_Resaon { get; set; }
		public System.Double? Total_Requested_Number { get; set; }
		public System.Guid? Document_Details_ID { get; set; }
	}
}
