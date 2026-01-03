namespace XOKA.Domain.Entities.HRA
{
    public class EmployementRequest
    {
		public System.Guid JOBPost_ID { get; set; }
		public System.Guid? application_code { get; set; }
		public System.Guid? Service_Code { get; set; }
		public string Service_Name { get; set; }
		public string Application_No { get; set; }
		public string Ref_NO { get; set; }
		public System.Guid? organization_code { get; set; }
		public System.Guid? Structure_ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public string Main_Innitiative_ID { get; set; }
		public System.DateTime? Application_StartDate { get; set; }
		public System.DateTime? Application_EndDate { get; set; }
		public bool? Is_Active { get; set; }
		public bool? internal_only { get; set; }
	}
}
