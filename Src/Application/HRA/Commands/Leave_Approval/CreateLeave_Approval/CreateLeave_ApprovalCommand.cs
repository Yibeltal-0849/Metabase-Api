using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Leave_Approval.CreateLeave_Approval
{
    /// @author  Shimels Alem  CreateCLeave_Approval stored procedure.
    
    public class CreateLeave_ApprovalCommand : IRequest<IList<LeaveApproval_Leave_Tran_ID>>
    {
        public Guid? Leave_Tran_ID { get; set; }
        public Guid? Leave_ID { get; set; }
        public bool? IS_Approved { get; set; }
        public string Remark { get; set; }
        public Guid? Approved_By { get; set; }
    }
}
