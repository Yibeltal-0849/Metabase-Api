namespace XOKA.Domain.Entities.HRA
{
    public class Attendance
    {
        public System.Guid Attendance_ID { get; set; }
        public System.Guid? Att_OT_Trans_Id { get; set; }
        public System.DateTime? Date { get; set; }
        public string Employee_ID { get; set; }
    }
}
