namespace XOKA.Domain.Entities.FixedAsset
{
    public class FixedAssetEntrust
    {
        public System.Guid Entrust_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
        public System.Guid? Entrust_Trans_ID { get; set; }
        public string Address { get; set; }
        public bool? Is_Active { get; set; }
        public System.Guid? Pervious_Enterus { get; set; }
        public string Record_No { get; set; }
        public string Remark { get; set; }
        public string Log { get; set; }
    }
}
