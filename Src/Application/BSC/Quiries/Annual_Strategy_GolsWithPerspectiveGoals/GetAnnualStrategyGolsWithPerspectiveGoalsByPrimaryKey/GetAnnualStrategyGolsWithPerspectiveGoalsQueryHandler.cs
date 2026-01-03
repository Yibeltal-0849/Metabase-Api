using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective.GetAnnualStrategyGolsWithPerspectiveGoalsLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective.GetAnnualStrategyGolsWithPerspectiveGoalsByPrimaryKey
{
    public class GetAnnualStrategyGolsWithPerspectiveGoalsQueryHandler :
        IRequestHandler<GetAnnualStrategyGolsWithPerspectiveGoalsByPrimaryKey, GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAnnualStrategyGolsWithPerspectiveGoalsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllListVm> Handle(GetAnnualStrategyGolsWithPerspectiveGoalsByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid PerspectiveGoal_ID = request.PerspectiveGoal_ID;
            IList<Proc_Annual_Strategy_GolsWithPerspective> annualGoals = await _procedureAdabter
               .Execute<Proc_Annual_Strategy_GolsWithPerspective>("[BSC].[proc_Annual_Strategy_GolsWithPerspective_GoalsLoadByPrimaryKey]", (nameof(PerspectiveGoal_ID), PerspectiveGoal_ID));
            GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllListVm vm = new GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllListVm
            {
                AnnualStrategicGoalsWithPerspective = _mapper.Map<IList<Proc_Annual_Strategy_GolsWithPerspective>, IList<GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllVm>>(annualGoals)
            };

            return vm;
        }
    }
}
