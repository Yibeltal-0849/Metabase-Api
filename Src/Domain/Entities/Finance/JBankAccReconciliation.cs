namespace XOKA.Domain.Entities.Finance
{
    public class JBankAccReconciliation
    {

        public System.Guid Branch_ID { get; set; }
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Transaction_Date { get; set; }
        public System.Guid Type_Bank_Reconcilliation { get; set; }
        public string Description { get; set; }
        public decimal? Statement_Amount { get; set; }
        public decimal Applied_Amount { get; set; }
        public decimal? Difference { get; set; }
        public string Document_No { get; set; }
    }
}
