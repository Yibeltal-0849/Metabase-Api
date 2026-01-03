
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblSector
	{
		public long id { get; set; }
		public string Name { get; set; }
		public bool? Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Modified { get; set; }
	}
}
