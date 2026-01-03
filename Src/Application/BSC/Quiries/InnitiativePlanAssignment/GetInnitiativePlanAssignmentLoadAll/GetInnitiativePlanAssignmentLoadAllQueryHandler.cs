using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.InnitiativePlanAssignment.GetInnitiativePlanAssignmentLoadAll
{
    class GetInnitiativePlanAssignmentLoadAllQueryHandler : IRequestHandler<GetInnitiativePlanAssignmentLoadAllQuery, GetInnitiativePlanAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetInnitiativePlanAssignmentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetInnitiativePlanAssignmentLoadAllListVm> Handle(GetInnitiativePlanAssignmentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Innitiative_Plan_Assignment> InnitiativePlanAssignments = await _procedureAdabter
               .Execute<Innitiative_Plan_Assignment>("[BSC].[proc_Innitiative_Plan_AssignmentLoadAll]");
            GetInnitiativePlanAssignmentLoadAllListVm vm = new GetInnitiativePlanAssignmentLoadAllListVm
            {
                InnitiativePlanAssignments = _mapper.Map<IList<Innitiative_Plan_Assignment>, IList<GetInnitiativePlanAssignmentLoadAllVm>>(InnitiativePlanAssignments)
            };

            return vm;
        }
    }
}
