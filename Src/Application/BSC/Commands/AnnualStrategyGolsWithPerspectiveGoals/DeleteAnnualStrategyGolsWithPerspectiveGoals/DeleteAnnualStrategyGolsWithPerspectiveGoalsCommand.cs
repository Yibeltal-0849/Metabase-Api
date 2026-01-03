using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Annual_Strategy_GolsWithPerspective.DeleteAnnualStrategyGolsWithPerspectiveGoals
{
    public class DeleteAnnualStrategyGolsWithPerspectiveGoalsCommand : IRequest<IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>>
    {
        public Guid PerspectiveGoal_ID { get; set; }
    }
}
