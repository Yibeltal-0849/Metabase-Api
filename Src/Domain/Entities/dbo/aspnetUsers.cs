namespace XOKA.Domain.Entities.dbo
{
    public class aspnetUsers
	{
		public System.Guid ApplicationId { get; set; }
		public System.Guid UserId { get; set; }
		public string UserName { get; set; }
		public string LoweredUserName { get; set; }
		public string MobileAlias { get; set; }
		public bool IsAnonymous { get; set; }
		public System.DateTime LastActivityDate { get; set; }
		public string FirstName_en { get; set; }
		public string LastName_en { get; set; }
		public string FirstName_Local { get; set; }
		public string LastName_Local { get; set; }
		public string MiddleName_en { get; set; }
		public string MiddleName_Local { get; set; }
		public bool? IsSuperUser{ get; set; }
		public int? IntID { get; set; }
		public string phone { get; set; }
		public bool? active { get; set; }
		public int? departments_id { get; set; }
		public string Status { get; set; }
		public bool? Is_Employee { get; set; }
		public bool? Is_synched { get; set; }
		public System.DateTime? Date_synched { get; set; }
		public System.Guid? Department_Code { get; set; }
		public System.Guid? Supervised_by { get; set; }
		public string email { get; set; }
		public long OfficeNo  { get; set; }
	}
}
