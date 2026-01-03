using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.procJobPlanAssignment.GetprocJobPlanAssignmentLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procJobPlanAssignment.GetprocJobPlanAssignmentByPrimaryKey
{
    public class GetprocJobPlanAssignmentQueryHandler : IRequestHandler<GetprocJobPlanAssignmentByPrimaryKey, GetprocJobPlanAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJobPlanAssignmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJobPlanAssignmentLoadAllListVm> Handle(GetprocJobPlanAssignmentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JobPlanAssignment> procJobPlanAssignments = await _procedureAdabter
               .Execute<JobPlanAssignment>("[BSC].[proc_Job_Plan_AssignmentLoadByPrimaryKey]", request);
            GetprocJobPlanAssignmentLoadAllListVm vm = new GetprocJobPlanAssignmentLoadAllListVm
            {
                procJobPlanAssignments = _mapper.Map<IList<JobPlanAssignment>, IList<GetprocJobPlanAssignmentLoadAllVm>>(procJobPlanAssignments)
            };

            return vm;
        }
    }
}
