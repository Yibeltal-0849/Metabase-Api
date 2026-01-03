namespace XOKA.Domain.Entities.HRA
{
    public class PlanedTraining
    {
        public System.Guid Training_Planed_ID { get; set; }
        public System.Guid? Application_Code { get; set; }
        public string Application_No { get; set; }
        public System.Guid? Service_Code { get; set; }
        public string Service_Name { get; set; }
        public System.Guid? Organization_code { get; set; }
        public string Training_ID { get; set; }
        public string Application_Start_Date { get; set; }
        public string Application_End_Date { get; set; }
        public System.DateTime? Training_Start_Date { get; set; }
        public System.DateTime? Training_End_Date { get; set; }
        public string Start_Hour { get; set; }
        public string End_Hour { get; set; }
        public string Training_Provider_ID { get; set; }
        public string Training_Provider_Name { get; set; }
        public string Location { get; set; }
        public string RequrementOf_Tranee { get; set; }
        public System.Guid? Certificate_ID { get; set; }
        public string Innitiative_ID { get; set; }

    }
}
