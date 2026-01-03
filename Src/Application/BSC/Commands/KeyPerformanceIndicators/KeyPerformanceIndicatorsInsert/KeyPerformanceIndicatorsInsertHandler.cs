using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.KeyPerformanceIndicators.KeyPerformanceIndicatorsInsert.KeyPerformanceIndicatorsInsertCommand
{ 
	 
      public class KeyPerformanceIndicatorsInsertHandler : IRequestHandler<KeyPerformanceIndicatorsInsertCommand, IList<Key_Performance_Indicators_KPI_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public KeyPerformanceIndicatorsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Key_Performance_Indicators_KPI_ID>> Handle( KeyPerformanceIndicatorsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Key_Performance_Indicators_KPI_ID> result = await _procedureAdabter
                .Execute<Key_Performance_Indicators_KPI_ID>("[BSC].Key_Performance_IndicatorsInsert", request);
           
            return result;
        }
    }
}
 
