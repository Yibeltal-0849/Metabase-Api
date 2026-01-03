namespace XOKA.Domain.Entities.Finance
{
    public class JPaymentJournal
    {
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string External_Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public string Currency_Code { get; set; }
        public decimal Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Applies_to_Doc_Type { get; set; }
        public string Applies_to_Doc_No { get; set; }
        public System.DateTime Applies_to_Doc_Due_Date { get; set; }
        public System.Guid Bank_Payment_Type { get; set; }
    }
}
