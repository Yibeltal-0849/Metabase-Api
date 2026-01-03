namespace XOKA.Domain.Entities.Finance
{
    public class PTransactionPurchaseType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Starting_No { get; set; }
        public string Ending_No { get; set; }
        public System.DateTime? Last_Date_Used { get; set; }
        public string Last_No_Used { get; set; }
        public string Default_Nos { get; set; }
        public string Manual_Nos { get; set; }
        public System.DateTime? Date_Order { get; set; }
        public string Pus_Posting_Group { get; set; }
        public System.Guid? Service_Code { get; set; }
    }
}
