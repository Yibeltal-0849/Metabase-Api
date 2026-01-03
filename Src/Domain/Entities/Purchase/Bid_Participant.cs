
namespace XOKA.Domain.Entities.Purchase
{
    public class Bid_Participant
	{
		public string Participant_ID { get; set; }
		public System.Guid? Bid_DetailID { get; set; }
		public string User_id { get; set; }
		public bool? Is_Customer { get; set; }
		public bool? Is_Vendor { get; set; }
		public string Customer_Id { get; set; }
		public string Vendor_ID { get; set; }
		public string Request_Number { get; set; }
		public bool? Is_Issued { get; set; }

	}
}
