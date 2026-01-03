using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidResult.GetBidResultLoadAll
{
    class GetBidResultLoadAllQueryHandler : IRequestHandler<GetBidResultLoadAllQuery, GetBidResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidResultLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidResultLoadAllListVm> Handle(GetBidResultLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Bid_Result> BidResults = await _procedureAdabter
               .Execute<_Bid_Result>("[Purchase].[proc_Bid_ResultLoadAll]");
            GetBidResultLoadAllListVm vm = new GetBidResultLoadAllListVm
            {
                BidResults = _mapper.Map<IList<_Bid_Result>, IList<GetBidResultLoadAllVm>>(BidResults)
            };

            return vm;
        }
    }
}
