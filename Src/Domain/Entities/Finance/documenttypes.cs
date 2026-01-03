namespace XOKA.Domain.Entities.Finance
{
    public class documenttypes
    {
        public System.Guid document_type_code { get; set; }
        public string description { get; set; }
	    public bool? is_synched { get; set; }
        public System.DateTime? date_synched { get; set; }
    }
}
