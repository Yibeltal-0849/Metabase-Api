using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procAnnualStrategicGoalsDetailsGroupByPerspective.GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAll;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetailsGroupByPerspective.GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveByPrimaryKey
{
    /// @author  Shimels Alem proc_Annual_Strategic_Goals_Details_GroupBy_PerspectiveLoadByPrimaryKey stored procedure.

    public class GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveByPrimaryKey : IRequest<GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllListVm>
    {
        public System.Guid ASGDGP_ID { get; set; }
    }
}
