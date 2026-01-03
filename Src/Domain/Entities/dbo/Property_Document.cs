namespace XOKA.Domain.Entities.dbo
{
    public class Property_Document
    {
        public System.Guid ID { get; set; }
        public string PROPERTY_ID { get; set; }
        public System.Guid? Updated_by { get; set; }
        public System.Guid? Deleted_by { get; set; }
        public string? Description { get; set; }
        public string? Documents { get; set; }
    }
}
