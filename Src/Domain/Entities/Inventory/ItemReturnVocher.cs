namespace XOKA.Domain.Entities.Inventory
{
    public class ItemReturnVocher
    {
        public string Requsition_ID { get; set; }
        public System.Guid? Application_Code { get; set; }
        public string Application_No { get; set; }
        public System.Guid? services_service_code { get; set; }
        public string Service_Name { get; set; }
        public System.Guid? To_organization_code { get; set; }
        public System.Guid? To_DIV { get; set; }
        public System.DateTime? Request_Date { get; set; }
        public bool? Is_For_rent { get; set; }
        public string Fixed_Asset_NO { get; set; }
        public string Address { get; set; }
        public System.Guid? Requested_By { get; set; }
        public string Ref_Job_Application_No { get; set; }
        public System.Guid? To_Be_Issued_To { get; set; }
        public string Remark { get; set; }
        public string Log { get; set; }
    }
}
