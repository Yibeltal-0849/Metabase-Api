using Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll; 
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.AnnualStrategicGoals;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.Finance.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsByPrimaryKey
{
    public class GetAnnualStrategicGoalsQueryHandler : IRequestHandler<GetAnnualStrategicGoalsByPrimaryKey, AnnualStrategicGoalsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAnnualStrategicGoalsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<AnnualStrategicGoalsLoadAllListVm> Handle(GetAnnualStrategicGoalsByPrimaryKey request, CancellationToken cancellationToken)
        {
            string Annual_Strategic_GoalID = request.Annual_Strategic_GoalID;
            IList<Proc_Annual_Strategic_Goals> annualGoals = await _procedureAdabter
               .Execute<Proc_Annual_Strategic_Goals>("[BSC].[proc_Annual_Strategic_GoalsLoadByPrimaryKey]", (nameof(Annual_Strategic_GoalID), Annual_Strategic_GoalID));
            AnnualStrategicGoalsLoadAllListVm vm = new AnnualStrategicGoalsLoadAllListVm
            {
                AnnualStrategicGoals = _mapper.Map<IList<Proc_Annual_Strategic_Goals>, IList<AnnualStrategicGoalsLoadAllVm>>(annualGoals)
            };

            return vm;
        }
    }
}
