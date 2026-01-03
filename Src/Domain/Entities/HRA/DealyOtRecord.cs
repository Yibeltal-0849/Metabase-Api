namespace XOKA.Domain.Entities.HRA
{
    public class DealyOtRecord
    {
        public System.Guid Dealy_OT_Record_ID { get; set; }
        public System.Guid? OR_ID { get; set; }
        public System.Guid? Deily_Attemdance_ID { get; set; }
        public System.Guid? OT_Type { get; set; }
        public double? Calculated_OT_Hours { get; set; }
        public double? Approved_OT_Hours { get; set; }
        public double? Calculated_Price { get; set; }
        public string Remark { get; set; }
    }
}
