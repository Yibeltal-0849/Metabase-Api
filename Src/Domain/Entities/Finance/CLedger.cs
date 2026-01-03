namespace XOKA.Domain.Entities.Finance
{
    public class CLedger
    {
        public System.DateTime Period_ID { get; set; }
        public string Account_ID { get; set; }
        public string Narration { get; set; }
        public double? Amount { get; set; }
    }
}
