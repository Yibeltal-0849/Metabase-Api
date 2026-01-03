using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceLoadAll;

namespace Application.HRA.Quiries.procDailyAttendance.GetprocDailyAttendanceByview
{
    /// @author  Shimels Alem proc_Daily_AttendanceLoadByPrimaryKey stored procedure.

    public class GetprocDailyAttendanceByview : IRequest<GetprocDailyAttendanceLoadAllListVm>
    {
        public Guid Att_OT_Trans_Id { get; set; }
    }
}
