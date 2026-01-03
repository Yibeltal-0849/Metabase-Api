using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procLeaveApproval.GetprocLeaveApprovalLoadAll;

namespace Application.HRA.Quiries.procLeaveApproval.GetprocLeaveApprovalByPrimaryKey
{
    /// @author  Shimels Alem proc_Leave_ApprovalLoadByPrimaryKey stored procedure.

    public class GetprocLeaveApprovalByPrimaryKey : IRequest<GetprocLeaveApprovalLoadAllListVm>
    {
        public System.Guid Leave_Tran_ID { get; set; }
    }
}
