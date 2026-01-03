using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.TaskPlanAssignment.GetTaskPlanAssignmentLoadAll;

namespace Application.BSC.Quiries.TaskPlanAssignment.GetTaskPlanAssignmentByPrimaryKey
{
    /// @author  Shimels Alem  GetTaskPlanAssignmentByPrimaryKey stored procedure.
    
    public class GetTaskPlanAssignmentByPrimaryKey : IRequest<GetTaskPlanAssignmentLoadAllListVm>
    {
        public Guid TPA_ID { get; set; }
    }
}
