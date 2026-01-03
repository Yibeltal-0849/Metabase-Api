namespace XOKA.Domain.Entities.Finance
{
    public class CPayrollTaxes
    {
        public long Id { get; set; }
        public string Orgcode { get; set; }
        public string TaxAgencyCode { get; set; }
        public string Tax_Liability_Acc_No { get; set; }
        public string Tax_Expense_Axx_No { get; set; }
        public string Compnay_Contribution { get; set; }
        public string Employe_Contribution { get; set; }
        public string Pen_Company_GL { get; set; }
        public string Pen_Employe_GL { get; set; }
    }
}
