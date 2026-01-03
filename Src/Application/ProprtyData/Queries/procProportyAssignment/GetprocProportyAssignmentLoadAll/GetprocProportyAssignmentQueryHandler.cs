using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procProportyAssignment.GetprocProportyAssignmentLoadAll
{
    class GetprocProportyAssignmentQueryHandler : IRequestHandler<GetprocProportyAssignmentQuery, GetprocProportyAssignmentListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProportyAssignmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProportyAssignmentListVm> Handle(GetprocProportyAssignmentQuery request, CancellationToken cancellationToken)
        {
            IList<Proporty_Assignment> procProportyAssignment = await _procedureAdabter
               .Execute<Proporty_Assignment>("[ProprtyData].[proc_Proporty_AssignmentLoadAll]");
            GetprocProportyAssignmentListVm vm = new GetprocProportyAssignmentListVm
            {
                procProportyAssignment = _mapper.Map<IList<Proporty_Assignment>, IList<GetprocProportyAssignmentLoadAllVm>>(procProportyAssignment)
            };

            return vm;
        }
    }
}
