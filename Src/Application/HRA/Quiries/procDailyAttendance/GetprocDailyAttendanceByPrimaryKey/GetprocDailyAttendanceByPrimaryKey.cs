using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceLoadAll;

namespace Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceByPrimaryKey
{
    /// @author  Shimels Alem proc_Daily_AttendanceLoadByPrimaryKey stored procedure.

    public class GetprocDailyAttendanceByPrimaryKey : IRequest<GetprocDailyAttendanceLoadAllListVm>
    {
        public Guid Deily_Attemdance_ID { get; set; }
    }
}
