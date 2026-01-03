namespace XOKA.Domain.Entities.HRA
{
    public class Trainee
    {
        public System.Guid? Training_Planed_ID { get; set; }
        public string Employee_ID { get; set; }
        public string Full_Name { get; set; }
        public bool? IS_Approved { get; set; }
        public System.Guid? Approved_By { get; set; }
        public string Remark { get; set; }
        public string Result { get; set; }
    }
}
