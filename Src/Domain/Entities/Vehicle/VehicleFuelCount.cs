namespace XOKA.Domain.Entities.Vehicle
{
    public class VehicleFuelCount
    {
        public System.Guid Vehicle_CountID { get; set; }
        public System.Guid? Vehicle_DispatchID { get; set; }
        public double? Fill_Amount { get; set; }
        public double? Last_Amount { get; set; }
        public System.Guid? document_detail_id { get; set; }
    }
}
