using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.InnitiativePlanAssignment.GetInnitiativePlanAssignmentLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.InnitiativePlanAssignment.GetInnitiativePlanAssignmentByPrimaryKey
{
    public class GetInnitiativePlanAssignmentQueryHandler : IRequestHandler<GetInnitiativePlanAssignmentByPrimaryKey, GetInnitiativePlanAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetInnitiativePlanAssignmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetInnitiativePlanAssignmentLoadAllListVm> Handle(GetInnitiativePlanAssignmentByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<Innitiative_Plan_Assignment> InnitiativePlanAssignments = await _procedureAdabter
               .Execute<Innitiative_Plan_Assignment>("[BSC].[proc_Innitiative_Plan_AssignmentLoadByPrimaryKey]", request);
            GetInnitiativePlanAssignmentLoadAllListVm vm = new GetInnitiativePlanAssignmentLoadAllListVm
            {
                InnitiativePlanAssignments = _mapper.Map<IList<Innitiative_Plan_Assignment>, IList<GetInnitiativePlanAssignmentLoadAllVm>>(InnitiativePlanAssignments)
            };

            return vm;
        }
    }
}
