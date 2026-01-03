using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadByPrimaryKeyAnnualStrategicGoalID
{
    public class GetprocAnnualStrategicGoalsDetailsQueryHandler : IRequestHandler<GetprocAnnualStrategicGoalsDetailsLoadByPrimaryKeyAnnualStrategicGoalID, GetprocAnnualStrategicGoalsDetailsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAnnualStrategicGoalsDetailsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAnnualStrategicGoalsDetailsLoadAllListVm> Handle(GetprocAnnualStrategicGoalsDetailsLoadByPrimaryKeyAnnualStrategicGoalID request, CancellationToken cancellationToken)
        {
           
            IList<AnnualStrategicGoalsDetails> procAnnualStrategicGoalsDetailss = await _procedureAdabter
               .Execute<AnnualStrategicGoalsDetails>("[BSC].[proc_Annual_Strategic_Goals_DetailsLoadByPrimaryKey_Annual_Strategic_GoalID]", request);
            GetprocAnnualStrategicGoalsDetailsLoadAllListVm vm = new GetprocAnnualStrategicGoalsDetailsLoadAllListVm
            {
                procAnnualStrategicGoalsDetailss = _mapper.Map<IList<AnnualStrategicGoalsDetails>, IList<GetprocAnnualStrategicGoalsDetailsLoadAllVm>>(procAnnualStrategicGoalsDetailss)
            };

            return vm;
        }
    }
}
