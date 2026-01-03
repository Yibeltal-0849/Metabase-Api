
namespace XOKA.Domain.Entities.Purchase
{
    public class Bid_Award
	{
		public System.Guid Bid_Award_ID { get; set; }
		public System.Guid? Bid_Result { get; set; }
		public string Award_Letter_Number { get; set; }
		public double? Award_Amount_Inc_VAT { get; set; }
		public string Currency { get; set; }
		public System.Guid? Bid_Award_Status { get; set; }
		public string Remark { get; set; }
		public System.Guid? created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }
	}
}
