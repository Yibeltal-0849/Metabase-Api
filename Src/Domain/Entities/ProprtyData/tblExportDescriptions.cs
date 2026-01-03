
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblExportDescriptions
	{
		public long id { get; set; }
		public long? Export_Id { get; set; }
		public long? Variable_id { get; set; }
		public string Value { get; set; }
	}
}
