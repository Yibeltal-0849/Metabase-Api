namespace XOKA.Domain.Entities.HRA
{
    public class DailyAttendance
    {
        public System.Guid Deily_Attemdance_ID { get; set; }
        public System.Guid? Attendance_ID { get; set; }
        public string Employee_ID { get; set; }
        public System.DateTime? Morning_In_Time { get; set; }
        public System.DateTime? Morning_Out_Time { get; set; }
        public System.DateTime? Afternoon_In_Time { get; set; }
        public System.DateTime? Afternoon_Out_Time { get; set; }
        public System.DateTime? Night_In_Time { get; set; }
        public System.DateTime? Night_Out_Time { get; set; }
        public double? Total_Working_Hours { get; set; }
        public double? Normal_Working_Hours { get; set; }
        public double? Absent_hours { get; set; }
        public bool? IS_IT_Approved_Leave { get; set; }
        public bool? IS_Holiday { get; set; }
        public System.Guid? Leave_ID { get; set; }
        public double? Proposed_OT_Hours { get; set; }
        public string Remark { get; set; }
    }
}
