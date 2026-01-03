namespace XOKA.Domain.Entities.dbo
{
    public class Contract
    {
        public string Contract_No { get; set; }
	    public string Contact_Name { get; set; }
	    public System.Guid? Organization_ID { get; set; }
        public System.Guid? DIV { get; set; }
	    public string Contract_Type { get; set; }
        public System.Guid? Application_Code { get; set; }
    }
}
