using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceAmount.GetproctblResourceAmountLoadAll
{
    class GetproctblResourceAmountLoadAllQueryHandler : IRequestHandler<GetproctblResourceAmountLoadAllQuery, GetproctblResourceAmountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceAmountLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceAmountLoadAllListVm> Handle(GetproctblResourceAmountLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceAmount> proctblResourceAmounts = await _procedureAdabter
               .Execute<tblResourceAmount>("[ProprtyData].[proc_tblResourceAmountLoadAll]");
            GetproctblResourceAmountLoadAllListVm vm = new GetproctblResourceAmountLoadAllListVm
            {
                proctblResourceAmounts = _mapper.Map<IList<tblResourceAmount>, IList<GetproctblResourceAmountLoadAllVm>>(proctblResourceAmounts)
            };

            return vm;
        }
    }
}
