using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumption.GetproctblConsumptionLoadAll
{
    class GetproctblConsumptionLoadAllQueryHandler : IRequestHandler<GetproctblConsumptionLoadAllQuery, GetproctblConsumptionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblConsumptionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumptionLoadAllListVm> Handle(GetproctblConsumptionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblConsumption> proctblConsumptions = await _procedureAdabter
               .Execute<tblConsumption>("[ProprtyData].[proc_tblConsumptionLoadAll]");
            GetproctblConsumptionLoadAllListVm vm = new GetproctblConsumptionLoadAllListVm
            {
                proctblConsumptions = _mapper.Map<IList<tblConsumption>, IList<GetproctblConsumptionLoadAllVm>>(proctblConsumptions)
            };

            return vm;
        }
    }
}
