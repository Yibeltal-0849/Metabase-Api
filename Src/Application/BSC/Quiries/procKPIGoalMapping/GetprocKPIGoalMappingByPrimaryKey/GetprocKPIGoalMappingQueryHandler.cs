using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.procKPIGoalMapping.GetprocKPIGoalMappingLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procKPIGoalMapping.GetprocKPIGoalMappingByPrimaryKey
{
    public class GetprocKPIGoalMappingQueryHandler : IRequestHandler<GetprocKPIGoalMappingByPrimaryKey, GetprocKPIGoalMappingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocKPIGoalMappingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocKPIGoalMappingLoadAllListVm> Handle(GetprocKPIGoalMappingByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<KPIGoalMapping> procKPIGoalMappings = await _procedureAdabter
               .Execute<KPIGoalMapping>("[BSC].[proc_KPI_Goal_MappingLoadByPrimaryKey]", request);
            GetprocKPIGoalMappingLoadAllListVm vm = new GetprocKPIGoalMappingLoadAllListVm
            {
                procKPIGoalMappings = _mapper.Map<IList<KPIGoalMapping>, IList<GetprocKPIGoalMappingLoadAllVm>>(procKPIGoalMappings)
            };

            return vm;
        }
    }
}
