using System;

namespace XOKA.Domain.Entities.HRA
{
    public class TrainingApplication
    {
        public System.Guid Training_Planed_ID { get; set; }
        public string Employee_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Your_Application { get; set; }
        public System.DateTime? End_Date { get; set; }
        public string Phone_Number { get; set; }
        public string email { get; set; }
        public bool? IS_Submited { get; set; }
        public System.Guid? Training_Application_Status { get; set; }
        public string Application_Evaluation_result { get; set; }
        public string Insert_Job_title { get; set; }
        public string Educational_Background { get; set; }
        public Guid? Department { get; set; }
        public bool? Is_Approved { get; set; }


    }
}
