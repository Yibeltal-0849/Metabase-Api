using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.procProportyAssignment.GetprocProportyAssignmentLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procProportyAssignment.GetprocProportyAssignmentByPrimaryKey
{
    public class GetprocProportyAssignmentByPrimaryKeyQueryHandler : IRequestHandler<GetprocProportyAssignmentByPrimaryKey, GetprocProportyAssignmentListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProportyAssignmentByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProportyAssignmentListVm> Handle(GetprocProportyAssignmentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Proporty_Assignment> procProportyAssignment = await _procedureAdabter
               .Execute<Proporty_Assignment>("[ProprtyData].[proc_Proporty_AssignmentLoadByPrimaryKey]", request);
            GetprocProportyAssignmentListVm vm = new GetprocProportyAssignmentListVm
            {
                procProportyAssignment = _mapper.Map<IList<Proporty_Assignment>, IList<GetprocProportyAssignmentLoadAllVm>>(procProportyAssignment)
            };

            return vm;
        }
    }
}
