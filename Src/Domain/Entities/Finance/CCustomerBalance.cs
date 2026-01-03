namespace XOKA.Domain.Entities.Finance
{
    public class CCustomerBalance
    {
        public long Id { get; set; }
        public string Org_id { get; set; }
        public string Customer_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_RAccount { get; set; }
    }
}
