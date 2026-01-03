
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblConsumed
	{
		public long? id  { get; set; }
		public long? Consumer_id { get; set; }
		public long? Energy_Id  { get; set; }
		public long? Varable_id { get; set; }
		public string Year { get; set; }
		public long? Unit { get; set; }
		public decimal? Value { get; set; }
		public string Source { get; set; }

	}
}
