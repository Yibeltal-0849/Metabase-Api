using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Daily_Attendance.DeleteDaily_Attendance
{
    /// @author  Shimels Alem  DeleteCDaily_Attendance stored procedure.
    
    public class DeleteDaily_AttendanceCommand : IRequest<IList<DailyAttendance_Deily_Attemdance_ID>>
    {
        public Guid Deily_Attemdance_ID { get; set; }
    }
}
