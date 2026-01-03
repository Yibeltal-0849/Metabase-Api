namespace XOKA.Domain.Entities.HRA
{
    public class AttendanceAndOtTransaction
    {
        public System.Guid Att_OT_Trans_Id { get; set; }
        public System.Guid? Application_Code { get; set; }
        public string Application_No { get; set; }
        public string Period { get; set; }
        public string Month_Name { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public System.Guid? organization_code { get; set; }
        public System.Guid? DIV { get; set; }
        public System.DateTime? TransactionDate { get; set; }
        public string Log { get; set; }
    }
}
