
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblExport
	{
		public long id { get; set; } 
		public long Company_id { get; set; } 
		public long? Energy_Chain_id { get; set; } 
		public long? Energy_id { get; set; } 
		public long Buyer_id { get; set; } 
		public System.DateTime Export_Period { get; set; } 
		public decimal Value { get; set; } 
		public long Unit { get; set; }

	}
}
