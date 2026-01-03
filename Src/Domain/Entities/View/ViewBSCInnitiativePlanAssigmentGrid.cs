namespace XOKA.Domain.Entities.view
{
    public class ViewBSCInnitiativePlanAssigmentGrid
    {
		public System.Guid IPA_ID { get; set; }
		public string Innitiative_ID { get; set; }
		public System.Guid? Assigned_Body { get; set; }
		public string Assigned_Body_Name { get; set; }
		public System.Guid? Responsible_Role { get; set; }
		public string Responsible_Role_Name { get; set; }
		public bool? Is_Active { get; set; }
		public System.Guid? ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public System.Guid? Assigned_By { get; set; }
		public string Assigned_By_name { get; set; }
		public bool? Is_Owner { get; set; }
		public System.Guid? Type_Of_Innitiative { get; set; }
		public string Innitiative { get; set; }
		public string Description { get; set; }
		public System.Double? Estimated_Cost_In_Birr { get; set; }
		public System.Double? Value_In_Per { get; set; }
		public string Unit { get; set; }
		public System.Double? Duration_In_Days { get; set; }
		public string Expected_Result { get; set; }
		public string Required_Inputs { get; set; }
		public int? Priority { get; set; }
		public System.Double? Estimated_Budget { get; set; }
		public string Budget_Account { get; set; }
		public System.DateTime? StartDate { get; set; }
		public System.DateTime? EndDate { get; set; }
		public string Parentinnitiative_ID { get; set; }
	}
}
