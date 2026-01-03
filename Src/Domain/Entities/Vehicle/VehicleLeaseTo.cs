namespace XOKA.Domain.Entities.Vehicle
{
    public class VehicleLeaseTo
    {
        public System.Guid Vehicle_LeaseToID { get; set; }
        public System.Guid? Customer_ID { get; set; }
        public double? Millage { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Remark { get; set; }
    }
}
