using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionLoadAll;

namespace XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionByPrimaryKey
{
    /// @author  Shimels Alem  proc_Attendance_and_OT_TransactionLoadByPrimaryKey stored procedure.

    public class GetAttendance_and_OT_TransactionByPrimaryKey : IRequest<GetAttendance_and_OT_TransactionLoadAllListVm>
    {
        public System.Guid Att_OT_Trans_Id { get; set; }
    }
}
