namespace XOKA.Domain.Entities.Vehicle
{
    public class VehicleRequestOrder
    {
        public System.Guid Vehicle_OrderID { get; set; }
        public System.Guid? Vehicle_RequestID { get; set; }
        public System.Guid? Employee_ID { get; set; }
        public System.DateTime? Order_Date { get; set; }
        public string PickUp_Location { get; set; }
        public bool? Is_Approved { get; set; }
        public string Destination { get; set; }
    }
}
