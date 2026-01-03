namespace XOKA.Domain.Entities.Finance
{
    public class CReceiveMoney
    {
        public string Deposit_TicketID { get; set; }
        public string Reference { get; set; }
        public string Receipt_Number { get; set; }
        public string InvouceID { get; set; }
        public bool? ISCustomer { get; set; }
        public string CustomerID { get; set; }
        public string Vendor_ID { get; set; }
        public decimal? Receipt_Amount { get; set; }
        public long? Payment_Method { get; set; }
    }
}
