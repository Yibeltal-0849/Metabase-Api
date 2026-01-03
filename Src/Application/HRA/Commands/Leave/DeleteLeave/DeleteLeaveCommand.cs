using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Leave.DeleteLeave
{
    /// @author  Shimels Alem  proc_LeaveDelete stored procedure.

    public class DeleteLeaveCommand : IRequest<IList<Leave_Leave_ID>>
    {
        public Guid Leave_ID { get; set; }
    }
}
