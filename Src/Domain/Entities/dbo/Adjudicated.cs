namespace XOKA.Domain.Entities.dbo
{
    public class Adjudicated
    {
        public System.Guid? Adjudicated_Code { get; set; }
        public System.Guid? application_code { get; set; }
        public string Plot_ID { get; set; }
        public System.DateTime? Adjudicated_Date { get; set; }
        public string Remark { get; set; }
        public bool IS_Adjudicated { get; set; }

    }
}
