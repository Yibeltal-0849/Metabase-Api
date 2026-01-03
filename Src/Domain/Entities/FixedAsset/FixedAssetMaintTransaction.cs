namespace XOKA.Domain.Entities.FixedAsset
{
    public class FixedAssetMaintTransaction
	{
		 public System.Guid FixedAsset_Maintan_Trans_ID { get; set; }
		 public string application_number { get; set; }
		 public System.DateTime? Request_Date { get; set; }
		 public System.Guid? services_service_code { get; set; }
		 public string Service_Name { get; set; }
		 public System.Guid? organization_code { get; set; }
		 public System.Guid? Requested_By { get; set; }
		 public System.Guid? DIV { get; set; }
		 public System.Guid? Created_By { get; set; }
		 public System.Guid? Updated_By { get; set; }
		 public string Log { get; set; }
	}
}
