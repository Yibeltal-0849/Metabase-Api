
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblConsumption
	{
		public long id { get; set; }
		public string Tranaction_Id { get; set; }
		public long? Companys_id { get; set; }
		public long? Energy_Id { get; set; }
		public bool? Complited { get; set; }

	}
}
