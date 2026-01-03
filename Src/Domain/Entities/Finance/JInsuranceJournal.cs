namespace XOKA.Domain.Entities.Finance
{
    public class JInsuranceJournal
    {
        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Insurance_No { get; set; }
        public string Fixed_Asset_No { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
    }
}
