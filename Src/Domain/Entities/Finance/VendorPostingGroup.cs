namespace XOKA.Domain.Entities.Finance
{
    public class VendorPostingGroup
    {
        public string Code { get; set; }
        public string Payables_Account { get; set; }
        public string Service_Charge_Account { get; set; }
        public string Payment_Disc_Debit_Account { get; set; }
        public string Payment_Disc_Credit_Account { get; set; }
        public string Interest_Account { get; set; }
        public int? Payment_tolerances_InDay { get; set; }
        public bool? IsActive { get; set; }
    }
}
