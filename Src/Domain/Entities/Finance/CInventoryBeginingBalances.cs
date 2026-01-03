namespace XOKA.Domain.Entities.Finance
{
    public class CInventoryBeginingBalances
    {
        public long Id { get; set; }
        public System.DateTime? Period { get; set; }
        public string OrgId { get; set; }
        public string Item_ID { get; set; }
        public string Description { get; set; }
        public decimal? Quantitiy { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
