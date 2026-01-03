namespace XOKA.Domain.Entities.HRA
{
    public class JobApplication
    {
        public string Job_AppID { get; set; }
        public System.Guid? application_code { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public System.DateTime? Application_Date { get; set; }
        public System.DateTime? Birth_Date { get; set; }
        public System.Guid? Nationality { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
        public string E_Mail { get; set; }
        public System.Guid? Application_Position { get; set; }
        public bool? Submited { get; set; }
        public System.Guid? Job_Application_Status { get; set; }
        public byte[] CV { get; set; }
        public bool Are_you_currently_employed_here { get; set; }
        public string Work_experience { get; set; }
        public string Education_type_level { get; set; }
        public string Payroll_ID { get; set; }

    }
}
