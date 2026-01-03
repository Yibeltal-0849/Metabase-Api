namespace XOKA.Domain.Entities.Finance
{
    public class JRecurringGeneralJournal
    {
        public System.Guid Branch_ID { get; set; }
        public string Recurring_Method { get; set; }
        public int? Recurring_Frequency { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public string Gen_Posting_Type { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Allocated_Amt { get; set; }
        public System.DateTime? Expiration_Date { get; set; }
    }
}
