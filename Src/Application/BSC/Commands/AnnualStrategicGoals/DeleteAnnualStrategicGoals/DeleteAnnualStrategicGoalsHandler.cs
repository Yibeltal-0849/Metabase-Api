using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.AnnualStrategicGoals.DeleteAnnualStrategicGoals
{
    public class DeleteAnnualStrategicGoalsHandler : IRequestHandler<DeleteAnnualStrategicGoalsCommand, IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteAnnualStrategicGoalsHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>> Handle(DeleteAnnualStrategicGoalsCommand request, CancellationToken cancellationToken)
        {
            string Annual_Strategic_GoalID = request.Annual_Strategic_GoalID;
            IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID> result = await _procedureAdabter
                .Execute<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>("[BSC].[proc_Annual_Strategic_GoalsDelete]", (nameof(Annual_Strategic_GoalID), Annual_Strategic_GoalID));

            return result;
        }
    }
}
