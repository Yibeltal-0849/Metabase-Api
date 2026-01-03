using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.ProcGoalsInnitiativeMapping.GetProcGoalsInnitiativeMappingLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcGoalsInnitiativeMapping.GetProcGoalsInnitiativeMappingByPrimaryKey
{
    public class GetProcGoalsInnitiativeMappingQueryHandler : IRequestHandler<GetProcGoalsInnitiativeMappingByPrimaryKey, GetProcGoalsInnitiativeMappingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetProcGoalsInnitiativeMappingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcGoalsInnitiativeMappingLoadAllListVm> Handle(GetProcGoalsInnitiativeMappingByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Proc_GoalsInnitiativeMapping> ProcGoalsInnitiativeMappings = await _procedureAdabter
               .Execute<Proc_GoalsInnitiativeMapping>("[FINA].[proc_Goals_Innitiative_MappingLoadByPrimaryKey]", request);
            GetProcGoalsInnitiativeMappingLoadAllListVm vm = new GetProcGoalsInnitiativeMappingLoadAllListVm
            {
                ProcGoalsInnitiativeMappings = _mapper.Map<IList<Proc_GoalsInnitiativeMapping>, IList<GetProcGoalsInnitiativeMappingLoadAllVm>>(ProcGoalsInnitiativeMappings)
            };

            return vm;
        }
    }
}
