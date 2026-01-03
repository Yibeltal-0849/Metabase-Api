namespace XOKA.Domain.Entities.HRA
{
    public class LeaveApproval
    {
        public System.Guid Leave_Tran_ID { get; set; }
        public System.Guid? Leave_ID { get; set; }
        public bool? IS_Approved { get; set; }
        public string Remark { get; set; }
        public System.Guid? Approved_By { get; set; }
    }
}
