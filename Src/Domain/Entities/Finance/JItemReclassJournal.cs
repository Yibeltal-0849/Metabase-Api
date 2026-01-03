namespace XOKA.Domain.Entities.Finance
{
    public class JItemReclassJournal
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public string UnitofMeasureCode { get; set; }
        public bool? Applies_to_Entry { get; set; }
    }
}
