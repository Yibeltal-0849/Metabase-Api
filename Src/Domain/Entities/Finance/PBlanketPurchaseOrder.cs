namespace XOKA.Domain.Entities.Finance
{
    public class PBlanketPurchaseOrder
    {
        public System.Guid Purchase_Line { get; set; }
        public int? Qty_to_Receive { get; set; }
        public int? Quantity_Received { get; set; }
        public int? Quantity_Invoiced { get; set; }
    }
}
