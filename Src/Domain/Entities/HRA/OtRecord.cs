namespace XOKA.Domain.Entities.HRA
{
    public class OtRecord
    {
        public System.Guid OT_ID { get; set; }
        public System.Guid? Att_OT_Trans_Id { get; set; }
        public System.DateTime? Start_Date_Time { get; set; }
        public System.DateTime? End_Date_Time { get; set; }
        public string Reason { get; set; }
        public string Managment_Reason { get; set; }
    }
}
