using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.TaskPlanAssignment.GetTaskPlanAssignmentLoadAll
{
    class GetTaskPlanAssignmentLoadAllQueryHandler : IRequestHandler<GetTaskPlanAssignmentLoadAllQuery, GetTaskPlanAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetTaskPlanAssignmentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTaskPlanAssignmentLoadAllListVm> Handle(GetTaskPlanAssignmentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Task_Plan_Assignment> TaskPlanAssignments = await _procedureAdabter
               .Execute<Task_Plan_Assignment>("[HRA].[proc_C_TaskPlanAssignmentLoadAll]");
            GetTaskPlanAssignmentLoadAllListVm vm = new GetTaskPlanAssignmentLoadAllListVm
            {
                TaskPlanAssignments = _mapper.Map<IList<Task_Plan_Assignment>, IList<GetTaskPlanAssignmentLoadAllVm>>(TaskPlanAssignments)
            };

            return vm;
        }
    }
}
