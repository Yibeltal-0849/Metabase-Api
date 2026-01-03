namespace XOKA.Domain.Entities.Vehicle
{
    public class MaintainanceAssignment
    {
        public long Ment_AssignmentID { get; set; }
        public string Maintainance_ID { get; set; }
        public string Assigned_To { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public string Status { get; set; }
    }
}
