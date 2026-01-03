namespace XOKA.Domain.Entities.Finance
{
    public class CJournalTypePosting
    {
        public string Type { get; set; }
        public int? Steps { get; set; }
        public string Start_Debit_Accounts { get; set; }
        public string Start_Credit_Accounts { get; set; }
    }
}
