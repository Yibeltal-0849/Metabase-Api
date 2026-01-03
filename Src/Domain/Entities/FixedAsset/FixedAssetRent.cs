namespace XOKA.Domain.Entities.FixedAsset
{
    public class FixedAssetRent
    {
        public long Rent_ID { get; set; }
        public long Item_ID { get; set; }
        public string Fixed_Asset_Type { get; set; }
        public string Contract_No { get; set; }
        public System.DateTime? Rent_Start_Date { get; set; }
        public System.DateTime? Rent_End_Date { get; set; }
        public double? Rent_Value { get; set; }
        public double? VAT { get; set; }
        public double? Total_RentValue { get; set; }
        public string Reference_Number { get; set; }
        public string Payment_Mode { get; set; }
        public string Applicatiom_Number { get; set; }
        public System.Guid? Application_Code { get; set; }
    }
}
