namespace XOKA.Domain.Entities.view
{
    public class ViewBSCAnualStrategicPlanAssignment
	{
		public System.Guid ASPA_ID { get; set; }
		public string ASGD_ID { get; set; }
		public string Annual_Strategic_GoalID { get; set; }
		public string Strategic_Goal { get; set; }
		public double Goal_Value_In_Per { get; set; }
		public System.Guid? Assigned_Body { get; set; }
		public string Assigned_Body_Name { get; set; }
		public System.Guid? Responsible_Role { get; set; }
		public string Responsible_Role_Name { get; set; }
		public bool? Is_Active { get; set; }
		public System.Guid? Assigned_By { get; set; }
		public string Assigned_By_Name { get; set; }
		public System.Guid? ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string Goal_Description { get; set; }
	}
}
