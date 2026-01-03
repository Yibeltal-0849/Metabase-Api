namespace XOKA.Domain.Entities.Finance
{
    public class JBomJournal
    {
        public string PostingDate { get; set; }
        public string DocumentNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public string Quantity { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string UnitCost { get; set; }
        public string TotalCost { get; set; }
    }
}
