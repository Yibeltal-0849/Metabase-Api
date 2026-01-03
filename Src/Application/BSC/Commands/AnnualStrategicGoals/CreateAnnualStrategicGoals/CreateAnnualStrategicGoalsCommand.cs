using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Application.BSC.Quiries.AnnualStrategicGoals;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.AnnualStrategicGoals.CreateAnnualStrategicGoals
{
    public class CreateAnnualStrategicGoalsCommand : AnnualStrategicGoalsLoadAllVm, IRequest<IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>>
    {

    }
}
