using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procKPIGoalMapping.GetprocKPIGoalMappingLoadAll
{
    class GetprocKPIGoalMappingLoadAllQueryHandler : IRequestHandler<GetprocKPIGoalMappingLoadAllQuery, GetprocKPIGoalMappingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocKPIGoalMappingLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocKPIGoalMappingLoadAllListVm> Handle(GetprocKPIGoalMappingLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<KPIGoalMapping> procKPIGoalMappings = await _procedureAdabter
               .Execute<KPIGoalMapping>("[BSC].[proc_KPI_Goal_MappingLoadAll]");
            GetprocKPIGoalMappingLoadAllListVm vm = new GetprocKPIGoalMappingLoadAllListVm
            {
                procKPIGoalMappings = _mapper.Map<IList<KPIGoalMapping>, IList<GetprocKPIGoalMappingLoadAllVm>>(procKPIGoalMappings)
            };

            return vm;
        }
    }
}
