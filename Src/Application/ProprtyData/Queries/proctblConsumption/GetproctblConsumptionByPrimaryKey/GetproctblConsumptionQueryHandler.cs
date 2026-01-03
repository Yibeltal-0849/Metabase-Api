using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblConsumption.GetproctblConsumptionLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumption.GetproctblConsumptionByPrimaryKey
{
    public class GetproctblConsumptionQueryHandler : IRequestHandler<GetproctblConsumptionByPrimaryKey, GetproctblConsumptionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblConsumptionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumptionLoadAllListVm> Handle(GetproctblConsumptionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblConsumption> proctblConsumptions = await _procedureAdabter
               .Execute<tblConsumption>("[ProprtyData].[proc_tblConsumptionLoadByPrimaryKey]", request);
            GetproctblConsumptionLoadAllListVm vm = new GetproctblConsumptionLoadAllListVm
            {
                proctblConsumptions = _mapper.Map<IList<tblConsumption>, IList<GetproctblConsumptionLoadAllVm>>(proctblConsumptions)
            };

            return vm;
        }
    }
}
