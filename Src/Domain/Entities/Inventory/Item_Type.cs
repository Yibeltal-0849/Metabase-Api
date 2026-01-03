namespace XOKA.Domain.Entities.Inventory
{
    public class Item_Type
    {
		public string Name  { get; set; }
		public string Description  { get; set; }
		public string Numbering_ID { get; set; }
		public string StartingNo  { get; set; }
		public string EndingNo  { get; set; }
		public System.DateTime? LastDateUsed { get; set; }
		public string LastNo_Used  { get; set; }
		public string Default_Nos  { get; set; }
		public string Manual_Nos  { get; set; }
		public System.DateTime? Date_Order { get; set; }
		public string Gen_Bus_Posting_Group  { get; set; }
		public System.Guid? Service_Code { get; set; }

	}
}
