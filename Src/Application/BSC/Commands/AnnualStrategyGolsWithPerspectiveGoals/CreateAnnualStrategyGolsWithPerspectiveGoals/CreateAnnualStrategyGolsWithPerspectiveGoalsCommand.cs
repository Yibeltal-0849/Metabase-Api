using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Annual_Strategy_GolsWithPerspective.CreateAnnualStrategyGolsWithPerspectiveGoals
{
    public class CreateAnnualStrategyGolsWithPerspectiveGoalsCommand : GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllVm ,IRequest<IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>>
    {
    }
}