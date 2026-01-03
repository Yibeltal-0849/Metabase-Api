namespace XOKA.Domain.Entities.FixedAsset
{
    public class MaintainancePartsChange
    {
        public System.Int64? PartsCange_ID { get; set; }
        public string Maintainance_ID { get; set; }
        public double? Unit_Cost { get; set; }
        public double? Quantity { get; set; }
        public double? Total_Cost { get; set; }
        public string Transfer_Req_DetailID { get; set; }
        public string Item_ID { get; set; }
        public bool? IsChanged { get; set; }

    }
}
