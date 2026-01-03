using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblConsumptionDetail.GetproctblConsumptionDetailLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumptionDetail.GetproctblConsumptionDetailByPrimaryKey
{
    public class GetproctblConsumptionDetailQueryHandler : IRequestHandler<GetproctblConsumptionDetailByPrimaryKey, GetproctblConsumptionDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblConsumptionDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumptionDetailLoadAllListVm> Handle(GetproctblConsumptionDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblConsumptionDetail> proctblConsumptionDetails = await _procedureAdabter
               .Execute<tblConsumptionDetail>("[ProprtyData].[proc_tblConsumption_DetailLoadByPrimaryKey]", request);
            GetproctblConsumptionDetailLoadAllListVm vm = new GetproctblConsumptionDetailLoadAllListVm
            {
                proctblConsumptionDetails = _mapper.Map<IList<tblConsumptionDetail>, IList<GetproctblConsumptionDetailLoadAllVm>>(proctblConsumptionDetails)
            };

            return vm;
        }
    }
}
