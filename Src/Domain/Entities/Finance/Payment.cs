namespace XOKA.Domain.Entities.Finance
{
    public class Payment
	{
		public System.Guid PID { get; set; }
		public System.Guid? To_do_ID { get; set; }
		public string Application_No { get; set; }
		public System.Guid Service_ID { get; set; }
		public System.Decimal Amount { get; set; }
		public bool? Process_Invoice { get; set; }
		public bool? Printed { get; set; }
		public string Description { get; set; }
		public System.DateTime? Date_Paid { get; set; }
		public string Invoice_No { get; set; }
		public System.Guid SDP_ID { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.Guid? Deleted_By { get; set; }
		public bool? Is_Deleted { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public System.DateTime? Deleted_Date { get; set; }
		public string Method { get; set; }
		public System.Decimal? Service_Fee { get; set; }
	}
}
