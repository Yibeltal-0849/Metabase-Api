using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.procAnnualStrategicGoalsDetailsGroupByPerspective.GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetailsGroupByPerspective.GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveByPrimaryKey
{
    public class GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveQueryHandler : IRequestHandler<GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveByPrimaryKey, GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllListVm> Handle(GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<AnnualStrategicGoalsDetailsGroupByPerspective> procAnnualStrategicGoalsDetailsGroupByPerspectives = await _procedureAdabter
               .Execute<AnnualStrategicGoalsDetailsGroupByPerspective>("[BSC].[proc_Annual_Strategic_Goals_Details_GroupBy_PerspectiveLoadByPrimaryKey]", request);
            GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllListVm vm = new GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllListVm
            {
                procAnnualStrategicGoalsDetailsGroupByPerspectives = _mapper.Map<IList<AnnualStrategicGoalsDetailsGroupByPerspective>, IList<GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllVm>>(procAnnualStrategicGoalsDetailsGroupByPerspectives)
            };

            return vm;
        }
    }
}
