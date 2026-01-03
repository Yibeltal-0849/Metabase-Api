
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblConsumptionDetail
	{
		public long? id { get; set; }
		public long Consumption_id { get; set; }
		public long SubSector_Id { get; set; }
		public long Unit_Id { get; set; }
		public string Sector_Number { get; set; }
		public decimal? Collected_Birr { get; set; }
		public decimal? Used_Amount { get; set; }
	}
}
