using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.AnnualStrategicGoals.DeleteAnnualStrategicGoals
{
    public class DeleteAnnualStrategicGoalsCommand : IRequest<IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>>
    {
        public string Annual_Strategic_GoalID { get; set; }
    }
}
