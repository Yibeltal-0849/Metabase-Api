namespace XOKA.Domain.Entities.Finance
{
    public class SBlanketSalesOrder
    {
        public string Sales_Blanket_Order_Line { get; set; }
        public int? Qty_to_Ship { get; set; }
        public int? Quantity_Shipped { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public System.DateTime? Shipment_Date { get; set; }
    }
}
