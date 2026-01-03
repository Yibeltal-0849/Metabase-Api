
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblResourceProduction
	{
		public long Facility_id { get; set; }
		public long Variable_id { get; set; }
		public System.DateTime Production_Period { get; set; }
		public string Month { get; set; }
		public string Year { get; set; }
		public long Unit { get; set; }
		public long Value { get; set; }
    }
}
