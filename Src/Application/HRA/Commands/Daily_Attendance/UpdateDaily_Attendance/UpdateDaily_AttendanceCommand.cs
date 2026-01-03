using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Daily_Attendance.UpdateDaily_Attendance
{
    /// @author  Shimels Alem  UpdateCDaily_Attendance stored procedure.
    
    public class UpdateDaily_AttendanceCommand : IRequest<IList<DailyAttendance_Deily_Attemdance_ID>>
    {
        public Guid Deily_Attemdance_ID { get; set; }
        public Guid? Attendance_ID { get; set; }
        public string Employee_ID { get; set; }
        public DateTime? Morning_In_Time { get; set; }
        public DateTime? Morning_Out_Time { get; set; }
        public DateTime? Afternoon_In_Time { get; set; }
        public DateTime? Afternoon_Out_Time { get; set; }
        public DateTime? Night_In_Time { get; set; }
        public DateTime? Night_Out_Time { get; set; }
        public double? Total_Working_Hours { get; set; }
        public double? Normal_Working_Hours { get; set; }
        public double? Absent_hours { get; set; }
        public bool? IS_IT_Approved_Leave { get; set; }
        public bool? IS_Holiday { get; set; }
        public Guid? Leave_ID { get; set; }
        public double? Proposed_OT_Hours { get; set; }
        public string Remark { get; set; }
    }
}
