using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumptionDetail.GetproctblConsumptionDetailLoadAll
{
    class GetproctblConsumptionDetailLoadAllQueryHandler : IRequestHandler<GetproctblConsumptionDetailLoadAllQuery, GetproctblConsumptionDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblConsumptionDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumptionDetailLoadAllListVm> Handle(GetproctblConsumptionDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblConsumptionDetail> proctblConsumptionDetails = await _procedureAdabter
               .Execute<tblConsumptionDetail>("[ProprtyData].[proc_tblConsumption_DetailLoadAll]");
            GetproctblConsumptionDetailLoadAllListVm vm = new GetproctblConsumptionDetailLoadAllListVm
            {
                proctblConsumptionDetails = _mapper.Map<IList<tblConsumptionDetail>, IList<GetproctblConsumptionDetailLoadAllVm>>(proctblConsumptionDetails)
            };

            return vm;
        }
    }
}
