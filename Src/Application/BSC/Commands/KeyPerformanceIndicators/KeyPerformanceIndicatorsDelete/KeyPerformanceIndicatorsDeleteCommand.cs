using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.KeyPerformanceIndicators.KeyPerformanceIndicatorsDelete.KeyPerformanceIndicatorsDeleteCommand
{

    ///   @author  Shimels Alem Key_Performance_IndicatorsDelete stored procedure.

    public class KeyPerformanceIndicatorsDeleteCommand : IRequest<IList<Key_Performance_Indicators_KPI_ID>>
    {
        public Guid KPI_ID { get; set; }
    }
		

	}
 
 
