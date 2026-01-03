using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Leave_Transaction.DeleteLeave_Transaction
{
    /// @author  Shimels Alem  proc_Leave_TransactionDelete stored procedure.

    public class DeleteLeave_TransactionCommand : IRequest<IList<LeaveApproval_Leave_Tran_ID>>
    {
        public Guid Leave_Tran_ID { get; set; }
    }
}
