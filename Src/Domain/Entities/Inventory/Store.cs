namespace XOKA.Domain.Entities.Inventory
{
    public class _Store
    {
        public string Store_code { get; set; }
        public string Store_Name { get; set; }
        public System.Guid? Store_Type { get; set; }
        public System.Guid? Organization { get; set; }
        public System.Guid? DIV { get; set; }
        public string Location { get; set; }
        public string Log { get; set; }
        public bool? Active { get; set; }
    }
}
