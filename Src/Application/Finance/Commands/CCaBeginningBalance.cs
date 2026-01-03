namespace XOKA.Domain.Entities.Finance
{
    public class CCaBeginningBalance
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
        public string Account_Decscrption { get; set; }
        public decimal? Assets_Expense { get; set; }
        public decimal? Liability_Equity_incom { get; set; }
    }
}
