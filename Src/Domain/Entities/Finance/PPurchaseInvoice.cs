namespace XOKA.Domain.Entities.Finance
{
    public class P_Purchase_Invoice
    {
        public System.Guid Purchase_Line { get; set; }
        public string Direct_Unit_Cost_Excl_VAT { get; set; }
        public double? Line_Discount_Per { get; set; }
        public System.Int32? Qty_to_Assign { get; set; }
        public System.Int32? Qty_Num_Assigned { get; set; }

    }
}
