using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadAll;

namespace Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadByPrimaryKeyAttOTTransId
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey_Att_OT_Trans_Id stored procedure.

    public class GetprocAttendanceLoadByPrimaryKeyAttOTTransId : IRequest<GetprocAttendanceLoadAllListVm>
    {
        public Guid Att_OT_Trans_Id { get; set; }
    }
}
