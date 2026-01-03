namespace XOKA.Domain.Entities.Finance
{
    public class FixedAssetEntrustTransaction
    {
		public System.Guid Entrust_Trans_ID { get; set; }
	    public string application_number { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public System.Guid? services_service_code { get; set; }
		public string Service_Name { get; set; }
		public System.Guid? organization_code { get; set; }
		public System.Guid? Requested_By { get; set; }
		public System.Guid? DIV { get; set; }
		public string Address { get; set; }
	}
}
