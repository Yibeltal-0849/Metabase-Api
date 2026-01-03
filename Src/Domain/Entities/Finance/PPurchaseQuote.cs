namespace XOKA.Domain.Entities.Finance
{
    public class PPurchaseQuote
    {
        public System.Guid Purchase_Line { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
}
