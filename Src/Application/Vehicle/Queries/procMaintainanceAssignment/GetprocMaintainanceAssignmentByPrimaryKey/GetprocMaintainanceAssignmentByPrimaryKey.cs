using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentLoadAll;

namespace Application.Vehicle.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentByPrimaryKey
{
    /// @author  Shimels Alem proc_Maintainance_AssignmentLoadByPrimaryKey stored procedure.

    public class GetprocMaintainanceAssignmentByPrimaryKey : IRequest<GetprocMaintainanceAssignmentLoadAllListVm>
    {
        public Int64? Ment_AssignmentID { get; set; }
    }
}
