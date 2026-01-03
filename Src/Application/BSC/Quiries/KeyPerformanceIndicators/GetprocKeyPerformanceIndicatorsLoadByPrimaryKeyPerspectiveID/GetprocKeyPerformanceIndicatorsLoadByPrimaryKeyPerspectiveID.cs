using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.KeyPerformanceIndicators.GetKeyPerformanceIndicatorsLoadAll;

namespace Application.BSC.Quiries.KeyPerformanceIndicators.GetprocKeyPerformanceIndicatorsLoadByPrimaryKeyPerspectiveID
{
    /// @author  Shimels Alem  proc_Key_Performance_IndicatorsLoadByPrimaryKey_Perspective_ID stored procedure.

    public class GetprocKeyPerformanceIndicatorsLoadByPrimaryKeyPerspectiveID : IRequest<GetKeyPerformanceIndicatorsLoadAllListVm>
    {
        public string Perspective_ID { get; set; }
    }
}
