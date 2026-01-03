using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcGoalsInnitiativeMapping.GetProcGoalsInnitiativeMappingLoadAll
{
    class GetProcGoalsInnitiativeMappingLoadAllQueryHandler : IRequestHandler<GetProcGoalsInnitiativeMappingLoadAllQuery, GetProcGoalsInnitiativeMappingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcGoalsInnitiativeMappingLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcGoalsInnitiativeMappingLoadAllListVm> Handle(GetProcGoalsInnitiativeMappingLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_GoalsInnitiativeMapping> ProcGoalsInnitiativeMappings = await _procedureAdabter
               .Execute<Proc_GoalsInnitiativeMapping>("[FINA].[proc_Goals_Innitiative_MappingLoadAll]");
            GetProcGoalsInnitiativeMappingLoadAllListVm vm = new GetProcGoalsInnitiativeMappingLoadAllListVm
            {
                ProcGoalsInnitiativeMappings = _mapper.Map<IList<Proc_GoalsInnitiativeMapping>, IList<GetProcGoalsInnitiativeMappingLoadAllVm>>(ProcGoalsInnitiativeMappings)
            };

            return vm;
        }
    }
}
