using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procJobPlanAssignment.GetprocJobPlanAssignmentLoadAll;

namespace Application.BSC.Quiries.procJobPlanAssignment.GetprocJobPlanAssignmentByPrimaryKey
{
    /// @author  Shimels Alem proc_Job_Plan_AssignmentLoadByPrimaryKey stored procedure.

    public class GetprocJobPlanAssignmentByPrimaryKey : IRequest<GetprocJobPlanAssignmentLoadAllListVm>
    {
        public System.Guid JobPA_ID { get; set; }
    }
}
