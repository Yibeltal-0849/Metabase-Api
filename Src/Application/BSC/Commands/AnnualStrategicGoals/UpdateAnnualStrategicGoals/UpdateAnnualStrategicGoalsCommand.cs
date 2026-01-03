using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.AnnualStrategicGoals;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.AnnualStrategicGoals.UpdateAnnualStrategicGoals
{
    public class UpdateAnnualStrategicGoalsCommand : AnnualStrategicGoalsLoadAllVm, IRequest<IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>>
    {
    }
}
