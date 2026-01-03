namespace XOKA.Domain.Entities.HRA
{
    public class OrganizationalStructureOrgCode
    {
        public System.Guid Structure_ID { get; set; }
        public System.Guid? DIV { get; set; }
        public System.Guid? Job_Position { get; set; }
        public string RoleName { get; set; }
        public string Eductional_Criteria { get; set; }
        public string Experiance_Criteria { get; set; }
        public string Training_Criteria { get; set; }
        public int? Addtional_Empolye_Needed { get; set; }
        public bool? Is_Active { get; set; }
        public string Remark { get; set; }
        public System.Guid organization_code { get; set;}
        //public double Basic_Salary { get; set; }
        //public string Provision { get; set; }
    }
}
