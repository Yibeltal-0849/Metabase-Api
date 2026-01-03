using Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll; 
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.AnnualStrategicGoals;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.Finance.Quiries.AnnualStrategicGoals.GetprocAnnualStrategicGoalsLoadByPrimaryKeyApplicationNumber
{
    public class GetAnnualStrategicGoalsQueryHandler : IRequestHandler<GetprocAnnualStrategicGoalsLoadByPrimaryKeyApplicationNumber, AnnualStrategicGoalsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAnnualStrategicGoalsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<AnnualStrategicGoalsLoadAllListVm> Handle(GetprocAnnualStrategicGoalsLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
            string Application_Number = request.Application_Number;
            IList<Proc_Annual_Strategic_Goals> annualGoals = await _procedureAdabter
               .Execute<Proc_Annual_Strategic_Goals>("[BSC].[proc_Annual_Strategic_GoalsLoadByPrimaryKey_Application_Number]", (nameof(Application_Number), Application_Number));
            AnnualStrategicGoalsLoadAllListVm vm = new AnnualStrategicGoalsLoadAllListVm
            {
                AnnualStrategicGoals = _mapper.Map<IList<Proc_Annual_Strategic_Goals>, IList<AnnualStrategicGoalsLoadAllVm>>(annualGoals)
            };

            return vm;
        }
    }
}
