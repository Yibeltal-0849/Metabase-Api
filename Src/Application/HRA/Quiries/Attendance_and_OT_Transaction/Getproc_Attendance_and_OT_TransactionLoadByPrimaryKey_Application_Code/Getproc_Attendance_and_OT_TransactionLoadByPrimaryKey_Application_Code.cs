using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.GetAttendance_and_OT_TransactionLoadAll;

namespace XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction.Getproc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code
{
    /// @author  Shimels Alem  proc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code stored procedure.

    public class Getproc_Attendance_and_OT_TransactionLoadByPrimaryKey_Application_Code : IRequest<GetAttendance_and_OT_TransactionLoadAllListVm>
    {
        public System.Guid Application_Code { get; set; }
    }
}
