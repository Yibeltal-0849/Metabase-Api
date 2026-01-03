namespace XOKA.Domain.Entities.Vehicle
{
    public class VehicleDispatch
    {
        public System.Guid Vehicle_DispatchID { get; set; }
        public System.Guid? Vehicle_RequestID { get; set; }
        public System.Guid? Vehicle_OrderID { get; set; }
        public System.DateTime Dispatch_Date { get; set; }
        public string Status { get; set; }
        public System.Guid ActiveVehicle_ID { get; set; }
        public string Driver_Name { get; set; }
    }
}
