using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.KeyPerformanceIndicators.GetKeyPerformanceIndicatorsLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.KeyPerformanceIndicators.GetprocKeyPerformanceIndicatorsLoadByPrimaryKeyPerspectiveID
{
    public class GetKeyPerformanceIndicatorsQueryHandler : IRequestHandler<GetprocKeyPerformanceIndicatorsLoadByPrimaryKeyPerspectiveID, GetKeyPerformanceIndicatorsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetKeyPerformanceIndicatorsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetKeyPerformanceIndicatorsLoadAllListVm> Handle(GetprocKeyPerformanceIndicatorsLoadByPrimaryKeyPerspectiveID request, CancellationToken cancellationToken)
        {
            IList<Key_Performance_Indicators> KeyPerformanceIndicatorss = await _procedureAdabter
               .Execute<Key_Performance_Indicators>("[BSC].[proc_Key_Performance_IndicatorsLoadByPrimaryKey_Perspective_ID]", request);
            GetKeyPerformanceIndicatorsLoadAllListVm vm = new GetKeyPerformanceIndicatorsLoadAllListVm
            {
                KeyPerformanceIndicatorss = _mapper.Map<IList<Key_Performance_Indicators>, IList<GetKeyPerformanceIndicatorsLoadAllVm>>(KeyPerformanceIndicatorss)
            };

            return vm;
        }
    }
}
