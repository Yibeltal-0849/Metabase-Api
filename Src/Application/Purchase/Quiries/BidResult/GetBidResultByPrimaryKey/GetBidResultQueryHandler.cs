using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.BidResult.GetBidResultLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidResult.GetBidResultByPrimaryKey
{
    public class GetBidResultQueryHandler : IRequestHandler<GetBidResultByPrimaryKey, GetBidResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidResultQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidResultLoadAllListVm> Handle(GetBidResultByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_Bid_Result> BidResults = await _procedureAdabter
               .Execute<_Bid_Result>("[Purchase].[proc_Bid_ResultLoadByPrimaryKey]", request);
            GetBidResultLoadAllListVm vm = new GetBidResultLoadAllListVm
            {
                BidResults = _mapper.Map<IList<_Bid_Result>, IList<GetBidResultLoadAllVm>>(BidResults)
            };

            return vm;
        }
    }
}
