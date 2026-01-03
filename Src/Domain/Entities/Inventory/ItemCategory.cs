namespace XOKA.Domain.Entities.Inventory
{
    public class Item_Category
    {
		public string Code { get; set; }
		public string Description { get; set; }
		public string Gen_Pord_Posting_Group { get; set; }
		public string Inventory_Posting_Group { get; set; }
		public string TAX_Prod_Posting_Group{ get; set; }
		public string Cost_Method { get; set; }
	}
}
