using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadAll;

namespace Application.HRA.Quiries.procAttendance.GetprocAttendanceByPrimaryKey
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey stored procedure.

    public class GetprocAttendanceByPrimaryKey : IRequest<GetprocAttendanceLoadAllListVm>
    {
        public Guid Attendance_ID { get; set; }
    }
}
