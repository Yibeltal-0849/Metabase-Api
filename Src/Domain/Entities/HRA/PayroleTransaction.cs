namespace XOKA.Domain.Entities.HRA
{
    public class PayroleTransaction
    {
        public System.Guid Payrole_Trans_Id { get; set; }
        public string Period { get; set; }
        public System.DateTime? start_Date { get; set; }
        public System.DateTime? End_date { get; set; }
        public string Month { get; set; }
        public bool? For_Permanent { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }
        public string Application_Number { get; set; }
        public System.Guid? Applicaation_Code { get; set; }
    }
}
