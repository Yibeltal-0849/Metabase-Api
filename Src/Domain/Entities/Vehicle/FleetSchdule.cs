namespace XOKA.Domain.Entities.Vehicle
{
    public class FleetSchdule
    {
        public System.Guid Fleet_SchduleID { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Vendor_ID { get; set; }
        public string Title { get; set; }
        public System.DateTime? Registration_Date { get; set; }
        public System.Guid? Fleet_Schdule_Type { get; set; }
        public bool? Is_Active { get; set; }
    }
}
