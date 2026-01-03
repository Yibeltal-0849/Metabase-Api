using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Attendance.DeleteAttendance
{
    /// @author  Shimels Alem  DeleteCAttendance stored procedure.
    
    public class DeleteAttendanceCommand : IRequest<IList<Attendance_Attendance_ID>>
    {
        public Guid Attendance_ID { get; set; }
    }
}
