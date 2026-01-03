namespace XOKA.Domain.Entities.Vehicle
{
    public class VehicleRequst
    {
        public System.Guid Vehicle_RequestID { get; set; }
        public string Requested_By { get; set; }
        public System.DateTime? Request_Date { get; set; }
        public System.DateTime? RequsetFor_Date { get; set; }
        public System.Guid? Application_code { get; set; }
        public string Application_No { get; set; }
    }
}
