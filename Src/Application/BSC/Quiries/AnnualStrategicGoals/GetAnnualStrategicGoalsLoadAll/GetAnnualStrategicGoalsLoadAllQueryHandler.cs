using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.AnnualStrategicGoals;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll
{
    public class GetAnnualStrategicGoalsLoadAllQueryHandler : IRequestHandler<GetAnnualStrategicGoalsLoadAllQuery, AnnualStrategicGoalsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetAnnualStrategicGoalsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<AnnualStrategicGoalsLoadAllListVm> Handle(GetAnnualStrategicGoalsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_Annual_Strategic_Goals> annualGoals = await _procedureAdabter
               .Execute<Proc_Annual_Strategic_Goals>("[BSC].[proc_Annual_Strategic_GoalsLoadAll]");
            AnnualStrategicGoalsLoadAllListVm vm = new AnnualStrategicGoalsLoadAllListVm
            {
                AnnualStrategicGoals = _mapper.Map<IList<Proc_Annual_Strategic_Goals>, IList<AnnualStrategicGoalsLoadAllVm>>(annualGoals)
            };

            return vm;
        }
    }
}
