using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Annual_Strategy_GolsWithPerspective.DeleteAnnualStrategyGolsWithPerspectiveGoals
{
    public class DeleteAnnualStrategyGolsWithPerspectiveGoalsHandler : IRequestHandler<DeleteAnnualStrategyGolsWithPerspectiveGoalsCommand, IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteAnnualStrategyGolsWithPerspectiveGoalsHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>> Handle(DeleteAnnualStrategyGolsWithPerspectiveGoalsCommand request, CancellationToken cancellationToken)
        {
            System.Guid?PerspectiveGoal_ID = request.PerspectiveGoal_ID;

            IList<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID> result = await _procedureAdabter
                .Execute<Proc_Annual_Strategy_GolsWithPerspective_PerspectiveGoal_ID>("[BSC].[Annual_Strategy_GolsWithPerspective_GoalsDelete]", (nameof(PerspectiveGoal_ID), PerspectiveGoal_ID));

            return result;

        }
    }
}
