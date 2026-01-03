namespace XOKA.Domain.Entities.Vehicle
{
    public class VehicleLease
    {
        public System.Guid Vehicle_LeaseID { get; set; }
        public string Vendor_ID { get; set; }
        public double? Millage { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Remark { get; set; }
        public string Application_Number { get; set; }
        public System.Guid? Application_Code { get; set; }
    }
}
