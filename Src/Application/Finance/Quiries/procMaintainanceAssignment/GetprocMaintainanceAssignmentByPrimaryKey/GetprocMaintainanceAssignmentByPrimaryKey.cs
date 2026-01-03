using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentLoadAll;

namespace Application.Finance.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentByPrimaryKey
{
    /// @author  Shimels Alem proc_Maintainance_AssignmentLoadByPrimaryKey stored procedure.

    public class GetprocMaintainanceAssignmentByPrimaryKey : IRequest<GetprocMaintainanceAssignmentLoadAllListVm>
    {
        public long Ment_AssignmentID { get; set; }
    }
}
