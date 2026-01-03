using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadAll;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadByPrimaryKeyAnnualStrategicGoalID
{
    /// @author  Shimels Alem proc_Annual_Strategic_Goals_DetailsLoadByPrimaryKey_Annual_Strategic_GoalID stored procedure.

    public class GetprocAnnualStrategicGoalsDetailsLoadByPrimaryKeyAnnualStrategicGoalID : IRequest<GetprocAnnualStrategicGoalsDetailsLoadAllListVm>
    {
        public string Annual_Strategic_GoalID { get; set; }
    }
}
