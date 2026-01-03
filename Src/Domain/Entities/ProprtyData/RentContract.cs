
namespace XOKA.Domain.Entities.ProprtyData
{
	public class RentContract
	{
		public System.Guid Rent_Contract_ID { get; set; }
		public string Property_ID { get; set; }
		public System.Guid? From_Organization_Code { get; set; }
		public System.Guid? Rent_Contract_Type { get; set; }
		public System.Guid? Service_Code { get; set; }
		public System.Guid? Application_Code { get; set; }
		public string Application_NO { get; set; }
		public string To_Customer { get; set; }
		public string Currency { get; set; }
		public string Unit { get; set; }
		public System.Double? Price { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public bool? Renew_Year { get; set; }
		public System.Guid? Renew_Contract_Document_Detail_ID { get; set; }
		public System.Guid Main_Contract_Document_Detail_ID { get; set; }
		public System.Guid? Parent_Contact { get; set; }
		public bool? Terminate { get; set; }
		public bool? Terminate_Remark { get; set; }
		public bool? Active { get; set; }
		public bool? Active_Remark { get; set; }
		public string Referance_Letter { get; set; }
		public System.Guid? Document_ID { get; set; }
		public string Contract_NO { get; set; }

	}
}
