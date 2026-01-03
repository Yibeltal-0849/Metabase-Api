using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Attendance.UpdateAttendance
{
    /// @author  Shimels Alem  UpdateCAttendance stored procedure.
    
    public class UpdateAttendanceCommand : IRequest<IList<Attendance_Attendance_ID>>
    {
        public Guid Attendance_ID { get; set; }
        public Guid? Att_OT_Trans_Id { get; set; }
        public DateTime? Date { get; set; }
        public string Employee_ID { get; set; }
    }
}
