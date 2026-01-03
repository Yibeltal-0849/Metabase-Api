namespace XOKA.Domain.Entities.Finance
{
    public class CTransactionDetailSales
    {
        public System.Guid Tran_Detail_Code { get; set; }
        public string orgid { get; set; }
        public string Trans_Id { get; set; }
        public long? Quantity { get; set; }
        public string Item { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? Tax { get; set; }
        public decimal Amount { get; set; }
    }
}
