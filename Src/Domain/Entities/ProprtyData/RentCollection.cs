
namespace XOKA.Domain.Entities.ProprtyData
{
    public class RentCollection
	{
		public System.Guid Rent_Collection_ID { get; set; }
		public System.Guid Rent_Contract_ID { get; set; }
		public System.Guid Month { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_date { get; set; }
		public bool? Collected { get; set; }
		public string Referance_NO { get; set; }

	}
}
