
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblSubSectors
	{
		public long id  { get; set; }
		public long? Main_Sector_id { get; set; }
		public string Name { get; set; }
		public string Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
	}
}
