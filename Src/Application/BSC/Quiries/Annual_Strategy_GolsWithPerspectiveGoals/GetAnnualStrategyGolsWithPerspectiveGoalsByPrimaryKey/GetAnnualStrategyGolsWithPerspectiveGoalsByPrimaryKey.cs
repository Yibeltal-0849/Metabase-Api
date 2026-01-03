using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective.GetAnnualStrategyGolsWithPerspectiveGoalsLoadAll;

namespace XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective.GetAnnualStrategyGolsWithPerspectiveGoalsByPrimaryKey
{
    public class GetAnnualStrategyGolsWithPerspectiveGoalsByPrimaryKey : IRequest<GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllListVm>
    {
        public Guid PerspectiveGoal_ID { get; set; }
    }
}
