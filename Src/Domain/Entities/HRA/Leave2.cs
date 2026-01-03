namespace XOKA.Domain.Entities.HRA
{
    public class Leave2
    {
		public System.Guid Leave_ID { get; set; }
		public System.Guid? Lease_Tran_ID { get; set; }
		public System.Double? Remaining_Leave { get; set; }
		public System.DateTime? Date_Applied { get; set; }
		public System.Guid? Leave_Type { get; set; }
		public System.DateTime? Leave_From_Date { get; set; }
		public System.DateTime? Leave_End_Date { get; set; }
		public string Substitute { get; set; }
		public string Verified_By { get; set; }
		public string Employee_ID { get; set; }
		public bool? With_Salary { get; set; }
		public bool? Without_Salary { get; set; }
		public System.Guid? Document_Details_ID { get; set; }
	}
}
