namespace XOKA.Domain.Entities.Finance
{
    public class PPurchaseOrder
    {
        public System.Guid? Purchase_Line_ID { get; set; }
        public double? Direct_Unit_Cost_Excl_VAT { get; set; }
        public double? Qty_to_Receive { get; set; }
        public double? Quantity_Received { get; set; }
        public double? Qty_to_Invoice { get; set; }
        public double? Quantity_Invoiced { get; set; }
        public double? Qty_to_Assign { get; set; }
        public double? Qty_Assigned { get; set; }
        public System.DateTime? Planned_Receipt_Date { get; set; }
        public System.DateTime? Expected_Receipt_Date { get; set; }
        public System.DateTime? Order_Date { get; set; }
    }
}
