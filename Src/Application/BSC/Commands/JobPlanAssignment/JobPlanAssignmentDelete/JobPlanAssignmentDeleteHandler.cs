using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.JobPlanAssignment.JobPlanAssignmentDelete.JobPlanAssignmentDeleteCommand
{

    /// @author  Shimels Alem  Job_Plan_AssignmentDelete stored procedure.

    public class JobPlanAssignmentDeleteHandler : IRequestHandler<JobPlanAssignmentDeleteCommand, IList<JobPlanAssignment_JobPA_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JobPlanAssignmentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobPlanAssignment_JobPA_ID>> Handle( JobPlanAssignmentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JobPlanAssignment_JobPA_ID> result = await _procedureAdabter
                .Execute<JobPlanAssignment_JobPA_ID>("[BSC].Job_Plan_AssignmentDelete", request);

            return result;
        }
    }
}
  