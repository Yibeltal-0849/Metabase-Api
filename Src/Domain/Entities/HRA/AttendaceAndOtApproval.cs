namespace XOKA.Domain.Entities.HRA
{
    public class AttendaceAndOtApproval
    {
        public System.Guid? ATT_OT_Trans_ID { get; set; }
        public bool? IS_Approved { get; set; }
        public System.Guid? Approved_By { get; set; }
        public string Remark { get; set; }
    }
}
