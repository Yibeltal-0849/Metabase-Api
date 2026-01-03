using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadAll
{
    class GetprocAnnualStrategicGoalsDetailsLoadAllQueryHandler : IRequestHandler<GetprocAnnualStrategicGoalsDetailsLoadAllQuery, GetprocAnnualStrategicGoalsDetailsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAnnualStrategicGoalsDetailsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAnnualStrategicGoalsDetailsLoadAllListVm> Handle(GetprocAnnualStrategicGoalsDetailsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AnnualStrategicGoalsDetails> procAnnualStrategicGoalsDetailss = await _procedureAdabter
               .Execute<AnnualStrategicGoalsDetails>("[BSC].[proc_Annual_Strategic_Goals_DetailsLoadAll]");
            GetprocAnnualStrategicGoalsDetailsLoadAllListVm vm = new GetprocAnnualStrategicGoalsDetailsLoadAllListVm
            {
                procAnnualStrategicGoalsDetailss = _mapper.Map<IList<AnnualStrategicGoalsDetails>, IList<GetprocAnnualStrategicGoalsDetailsLoadAllVm>>(procAnnualStrategicGoalsDetailss)
            };

            return vm;
        }
    }
}
