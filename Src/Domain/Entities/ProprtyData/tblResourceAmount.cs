
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblResourceAmount
	{
		public long Resource_id { get; set; }
		public long ResourceVariable_id { get; set; }
		public System.DateTime Report_Period { get; set; }
		public string Month { get; set; }
		public string Year { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }

	}
}
