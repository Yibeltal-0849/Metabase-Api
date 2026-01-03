using System;

namespace XOKA.Domain.Entities.HRA
{
    public class DailyAttendance_Deily_Attemdance_view
    {
        public System.Guid Att_OT_Trans_Id { get; set; }
        public string Period { get; set; }
        public string Application_No { get; set; }
        public string Month_Name { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<System.Guid> organization_code { get; set; }
        public Nullable<System.Guid> DIV { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public System.Guid Attendance_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Employee_ID { get; set; }
        public System.Guid Deily_Attemdance_ID { get; set; }
        public Nullable<System.DateTime> Morning_In_Time { get; set; }
        public Nullable<System.DateTime> Morning_Out_Time { get; set; }
        public Nullable<System.DateTime> Afternoon_In_Time { get; set; }
        public Nullable<System.DateTime> Afternoon_Out_Time { get; set; }
        public Nullable<System.DateTime> Night_In_Time { get; set; }
        public Nullable<System.DateTime> Night_Out_Time { get; set; }
        public Nullable<double> Total_Working_Hours { get; set; }
        public Nullable<double> Normal_Working_Hours { get; set; }
        public Nullable<double> Absent_hours { get; set; }
        public Nullable<bool> IS_IT_Approved_Leave { get; set; }
        public Nullable<bool> IS_Holiday { get; set; }
        public Nullable<System.Guid> Leave_ID { get; set; }
        public Nullable<double> Proposed_OT_Hours { get; set; }
        public string Remark { get; set; }

    }
}
