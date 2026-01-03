
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblResource
	{
		public long id{ get; set; }
		public string International_Code { get; set; }
		public string RNumber { get; set; }
		public long Energy_Id { get; set; }
		public long EnergyChain_id { get; set; }
		public string Site_Name { get; set; }
		public string Specific_Location_Name { get; set; }
		public long? Owner_Id { get; set; }
		public long? Facility_id  { get; set; }
		public long? Status_id  { get; set; }
		public long? Region  { get; set; }
		public long? Zone  { get; set; }
		public long? Worda_id  { get; set; }
		public string UTME { get; set; }
		public System.DateTime Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
		public bool? Enable { get; set; }
		public string Data_Owner { get; set; }
		public bool? Regional_Approve { get; set; }
		public bool? Federal_Approve { get; set; }
		public bool? PublicApprove { get; set; }

	}
}
