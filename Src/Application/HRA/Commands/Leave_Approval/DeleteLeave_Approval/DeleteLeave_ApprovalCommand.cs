using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Leave_Approval.DeleteLeave_Approval
{
    /// @author  Shimels Alem  DeleteCLeave_Approval stored procedure.
    
    public class DeleteLeave_ApprovalCommand : IRequest<IList<LeaveApproval_Leave_Tran_ID>>
    {
        public Guid Leave_Tran_ID { get; set; }
    }
}
