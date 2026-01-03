using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Annual_Strategy_GolsWithPerspective.UpdateAnnualStrategyGolsWithPerspectiveGoals
{
    public class UpdateAnnualStrategyGolsWithPerspectiveGoalsHandler : IRequestHandler<UpdateAnnualStrategyGolsWithPerspectiveGoalsCommand, IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateAnnualStrategyGolsWithPerspectiveGoalsHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>> Handle(UpdateAnnualStrategyGolsWithPerspectiveGoalsCommand request, CancellationToken cancellationToken)
        {
            System.Guid?PerspectiveGoal_ID = request.PerspectiveGoal_ID;
            string Perspective_ID = request.Perspective_ID;
            string Annual_Strategic_GoalID = request.Annual_Strategic_GoalID;
            double? Perspective_Value_IN_Per = request.Perspective_Value_IN_Per;

            IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID> result = await _procedureAdabter
                .Execute<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>("[BSC].[Annual_Strategy_GolsWithPerspective_GoalsUpdate]", (nameof(PerspectiveGoal_ID), PerspectiveGoal_ID), (nameof(Perspective_ID), Perspective_ID),
                (nameof(Annual_Strategic_GoalID), Annual_Strategic_GoalID), (nameof(Perspective_Value_IN_Per), Perspective_Value_IN_Per));

            return result;
        }
    }
}
