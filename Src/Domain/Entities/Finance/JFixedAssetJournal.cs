namespace XOKA.Domain.Entities.Finance
{
    public class JFixedAssetJournal
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string FA_No { get; set; }
        public string Book_Code { get; set; }
        public string FA_Posting_Type { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public int Year { get; set; }
        public System.DateTime? Period { get; set; }
        public string GL_EnteryNO { get; set; }
    }
}
