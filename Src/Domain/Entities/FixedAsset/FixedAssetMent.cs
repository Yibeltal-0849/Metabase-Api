namespace XOKA.Domain.Entities.FixedAsset
{
    public class FixedAssetMent
    {
    public string Maintainance_ID { get; set; }
	public System.Guid? FixedAsset_Maintan_Trans_ID { get; set; }
    public System.DateTime? Mainanace_Request_Date { get; set; }
	public string FIXED_Asset_No { get; set; }
	public string Unit { get; set; }
	public double? Quantity { get; set; }
	public string Remark { get; set; }
	public string Vocher_NO { get; set; }
    }
}
