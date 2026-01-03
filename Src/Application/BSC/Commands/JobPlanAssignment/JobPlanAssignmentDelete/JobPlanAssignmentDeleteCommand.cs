 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.JobPlanAssignment.JobPlanAssignmentDelete.JobPlanAssignmentDeleteCommand
{

    // @author  Shimels Alem  Job_Plan_AssignmentDelete stored procedure.

    public class JobPlanAssignmentDeleteCommand : IRequest<IList<JobPlanAssignment_JobPA_ID>>
    {
        public System.Guid JobPA_ID { get; set; }

    }




}
 
 