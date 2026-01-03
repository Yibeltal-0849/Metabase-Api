namespace XOKA.Domain.Entities.view
{
    public class ViewINVItemAcitivityGrid
    {
        public string Vocher_NO { get; set; }
        public System.Guid? Application_Code { get; set; }
        public string Application_No { get; set; }
        public string TypeOf_Activity { get; set; }
        public string TypeOf_Activity_name { get; set; }
        public string Vendor { get; set; }
        public string Vendor_Name { get; set; }
        public System.Guid? services_service_code { get; set; }
        public string Service_Name { get; set; }
        public System.Guid? From_Organization { get; set; }
        public string From_Org_Nmae { get; set; }
        public System.Guid? From_DIV { get; set; }
        public string From_DIV_Name { get; set; }
        public System.Guid? To_Organization { get; set; }
        public string To_Org_Name { get; set; }
        public System.Guid? To_DIV { get; set; }
        public string To_DIV_Name { get; set; }
        public System.DateTime? Request_Date { get; set; }
        public string Address { get; set; }
        public System.Guid? Requested_By { get; set; }
        public string Requested_By_Name { get; set; }
        public string Purchase_Order_Num { get; set; }
        public string Ref_Job_Application_No { get; set; }
        public System.Guid? To_Be_Issued_To { get; set; }
        public System.Guid? Recived_By { get; set; }
        public string Recived_By_Name { get; set; }
        public string From_Store { get; set; }
        public string To_Store { get; set; }
        public string Parent_No { get; set; }
        public string Remark { get; set; }
        public string Innitiative_ID { get; set; }
    }
}
