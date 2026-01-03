namespace XOKA.Domain.Entities.Inventory
{
    public class C_Items
    {
        public string Item_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrgCode { get; set; }
        public string Item_Type { get; set; }
        public string Json_Meta_Data { get; set; }
        public string Json_Data { get; set; }
        public string Log { get; set; }
        public string Application_No { get; set; }
        public System.DateTime? Created_Date  { get; set; }
        public System.Guid? Created_By { get; set; }
    }
}
