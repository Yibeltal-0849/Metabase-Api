using Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll; 
using MediatR;

namespace XOKA.Application.Finance.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsByPrimaryKey
{
    public class GetAnnualStrategicGoalsByPrimaryKey : IRequest<AnnualStrategicGoalsLoadAllListVm>
    {
        public string Annual_Strategic_GoalID { get; set; }
    }
}
