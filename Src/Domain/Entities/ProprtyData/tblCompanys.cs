
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblCompanys
	{
		public long  id { get; set; }
		public string Name { get; set; }
		public long? Region { get; set; }
		public bool? IsLocal { get; set; }
		public string Operating_Area { get; set; }
		public decimal? Capital { get; set; }
		public string Mistion { get; set; }
		public string vistion { get; set; }
		public string Objective { get; set; }
		public byte[]? LastUpdated { get; set; }
		public string More_info { get; set; }
		public long OrgType { get; set; }
	}

}
