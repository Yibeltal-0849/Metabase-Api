using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceAmount.GetproctblResourceAmountLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceAmount.GetproctblResourceAmountByPrimaryKey
{
    public class GetproctblResourceAmountQueryHandler : IRequestHandler<GetproctblResourceAmountByPrimaryKey, GetproctblResourceAmountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceAmountQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceAmountLoadAllListVm> Handle(GetproctblResourceAmountByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceAmount> proctblResourceAmounts = await _procedureAdabter
               .Execute<tblResourceAmount>("[ProprtyData].[proc_tblResourceAmountLoadByPrimaryKey]", request);
            GetproctblResourceAmountLoadAllListVm vm = new GetproctblResourceAmountLoadAllListVm
            {
                proctblResourceAmounts = _mapper.Map<IList<tblResourceAmount>, IList<GetproctblResourceAmountLoadAllVm>>(proctblResourceAmounts)
            };

            return vm;
        }
    }
}
