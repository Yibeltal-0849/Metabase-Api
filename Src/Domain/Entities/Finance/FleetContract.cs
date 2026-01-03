using System;

namespace XOKA.Domain.Entities.Finance
{
    public class FleetContract
	{
		public string Contract_ID { get; set; }
		public System.Guid? Customer_ID { get; set; }
		public string Contract_Title { get; set; }
		public System.Guid? Organization_ID { get; set; }
		public System.Guid? Vendor_ID { get; set; }
		public System.Double? Contract_Amount { get; set; }
		public string Fleet_Contract_Type { get; set; }
		public string Is_Active { get; set; }
	}
}
