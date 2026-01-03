namespace XOKA.Domain.Entities.Finance
{
    public class LJobLedgerEntries
    {
        public string PostingDate { get; set; }
        public string EntryType { get; set; }
        public string DocumentNo { get; set; }
        public string JobNo { get; set; }
        public string JobTaskNo { get; set; }
        public string Type { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public string WorkTypeCode { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string Quantity { get; set; }
        public string UnitCost { get; set; } 
        public string TotalCost { get; set; } 
        public string UnitPrice { get; set; }
        public string LineAmount { get; set; }
        public string LineDiscountAmount { get; set; }
        public string LineDiscountPer { get; set; }
        public string LedgerEntryType { get; set; }
        public string LedgerEntryNo { get; set; }
        public string EntryNo { get; set; }
        public string Adjusted { get; set; }
        public string DateTimeAdjusted { get; set; }
    }
}
