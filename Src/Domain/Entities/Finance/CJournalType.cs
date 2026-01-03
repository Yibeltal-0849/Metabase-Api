namespace XOKA.Domain.Entities.Finance
{
    public class CJournalType
    {
        public string Type { get; set; }
        public string Debit_Accounts { get; set; }
        public string Credit_Accounts { get; set; }
        public System.Guid? Visable_For_Form { get; set; }
        public string No_Series { get; set; }
    }
}
