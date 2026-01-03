using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Proc_GeneratePaySlipreport.Proc_GeneratePaySlipreportLoadAll;

namespace XOKA.Application.HRA.Quiries.Proc_GeneratePaySlipreport.Proc_GeneratePaySlipreportByPrimaryKey
{
    /// @author  Shimels Alem  proc_Attendance_and_OT_TransactionLoadByPrimaryKey stored procedure.

    public class GetProc_GeneratePaySlipreportByPrimaryKey : IRequest<GetProc_GeneratePaySlipreportLoadAllListVm>
    {
        public string Employee_ID { get; set; }
    }
}
