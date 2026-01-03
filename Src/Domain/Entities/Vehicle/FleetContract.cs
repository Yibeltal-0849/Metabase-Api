namespace XOKA.Domain.Entities.Vehicle
{
    public class FleetContract
    {
        public string Contract_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Contract_Title { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public string Vendor_ID { get; set; }
        public double? Contract_Amount { get; set; }
        public string Fleet_Contract_Type { get; set; }
        public string Is_Active { get; set; }
    }
}
