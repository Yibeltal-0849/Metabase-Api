namespace XOKA.Domain.Entities.HRA
{
    public class WorkInfo2
    {
        public System.Guid WorkInfo_ID { get; set; }
        public string Employee_ID { get; set; }
        public System.Guid? Branch { get; set; }
        public System.Guid? DIV { get; set; }
        public string Provision { get; set; }
        public string E_Mail { get; set; }
        public string Work_Phone_Number { get; set; }
        public string Cell_Phone_Number { get; set; }
        public string Job_Title { get; set; }
        public System.Guid? Employement_Request { get; set; }
        public bool? IS_Active { get; set; }
    }
}
