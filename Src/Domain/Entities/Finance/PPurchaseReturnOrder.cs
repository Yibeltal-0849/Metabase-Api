namespace XOKA.Domain.Entities.Finance
{
    public class PPurchaseReturnOrder
    {
        public System.Guid Purchase_Line { get; set; }
        public System.Guid? Return_Reason_Code { get; set; }
        public int? Return_Qty_to_Ship { get; set; }
        public int? Return_Qty_Shipped { get; set; }
        public int? Qty_to_Invoice { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
}
