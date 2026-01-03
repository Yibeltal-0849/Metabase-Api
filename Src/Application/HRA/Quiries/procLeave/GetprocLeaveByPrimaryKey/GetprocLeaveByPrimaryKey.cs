using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procLeave.GetprocLeaveLoadAll;

namespace Application.HRA.Quiries.procLeave.GetprocLeaveByPrimaryKey
{
    /// @author  Shimels Alem proc_LeaveLoadByPrimaryKey stored procedure.

    public class GetLeaveTypeLookupByIdQuery : IRequest<GetprocLeaveLoadAllListVm>
    {
        public Guid Leave_ID { get; set; }
    }
}
