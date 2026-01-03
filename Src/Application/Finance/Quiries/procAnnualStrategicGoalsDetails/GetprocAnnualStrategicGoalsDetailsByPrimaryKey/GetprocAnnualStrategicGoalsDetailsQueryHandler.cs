using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsByPrimaryKey
{
    public class GetprocAnnualStrategicGoalsDetailsQueryHandler : IRequestHandler<GetprocAnnualStrategicGoalsDetailsByPrimaryKey, GetprocAnnualStrategicGoalsDetailsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAnnualStrategicGoalsDetailsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAnnualStrategicGoalsDetailsLoadAllListVm> Handle(GetprocAnnualStrategicGoalsDetailsByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<proc_AnnualStrategicGoalsDetails> procAnnualStrategicGoalsDetailss = await _procedureAdabter
               .Execute<proc_AnnualStrategicGoalsDetails>("[FINA].[proc_Annual_Strategic_Goals_DetailsLoadByPrimaryKey]", request);
            GetprocAnnualStrategicGoalsDetailsLoadAllListVm vm = new GetprocAnnualStrategicGoalsDetailsLoadAllListVm
            {
                procAnnualStrategicGoalsDetailss = _mapper.Map<IList<proc_AnnualStrategicGoalsDetails>, IList<GetprocAnnualStrategicGoalsDetailsLoadAllVm>>(procAnnualStrategicGoalsDetailss)
            };

            return vm;
        }
    }
}
