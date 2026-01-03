using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.KeyPerformanceIndicators.GetKeyPerformanceIndicatorsLoadAll;

namespace Application.BSC.Quiries.KeyPerformanceIndicators.GetKeyPerformanceIndicatorsByPrimaryKey
{
    /// @author  Shimels Alem  proc_Key_Performance_IndicatorsLoadByPrimaryKey stored procedure.

    public class GetKeyPerformanceIndicatorsByPrimaryKey : IRequest<GetKeyPerformanceIndicatorsLoadAllListVm>
    {
        public Guid KPI_ID { get; set; }
    }
}
