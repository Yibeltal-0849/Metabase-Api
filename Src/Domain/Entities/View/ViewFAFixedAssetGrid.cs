namespace XOKA.Domain.Entities.view
{
    public class ViewFAFixedAssetGrid
	{
		public string FIXED_Asset_No { get; set; }
		public System.Guid? FixedAsset_Trans_ID { get; set; }
		public string Name { get; set; }
		public string Fixed_Asset_Posting_Group { get; set; }
		public System.Guid? Asset_Status_Type { get; set; }
		public string Asset_Status_Type_Name { get; set; }
		public System.Guid? FA_Class_Code { get; set; }
		public string FA_Class_Code_Name { get; set; }
		public System.Guid? FA_Class_Sub_Code { get; set; }
		public string FA_Class_Code_Sub_Code { get; set; }
		public string Factory_Number { get; set; }
		public System.Double? Value { get; set; }
		public System.DateTime? Purchased_Date { get; set; }
		public System.DateTime? Received_Date { get; set; }
		public System.DateTime? Commission_Date { get; set; }
		public System.DateTime? Depreciation_Start_Date { get; set; }
		public string Record_No { get; set; }
		public System.Int32? Quantity { get; set; }
		public string Unit { get; set; }
		public string Remark { get; set; }
	}
}
