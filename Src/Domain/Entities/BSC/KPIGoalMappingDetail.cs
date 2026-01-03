
namespace XOKA.Domain.Entities.Bsc
{
    public class KPIGoalMappingDetail
	{
		public System.Guid Mapping_DetailID { get; set; }
		public System.Guid KPIMapping_ID { get; set; }
		public System.Int32 Budget_Year { get; set; }
		public string Unit { get; set; }
		public long Value { get; set; }



	}
}
