using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.BidOpening.GetBidOpeningLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidOpening.GetBidOpeningByPrimaryKey
{
    public class GetBidOpeningQueryHandler : IRequestHandler<GetBidOpeningByPrimaryKey, GetBidOpeningLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidOpeningQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidOpeningLoadAllListVm> Handle(GetBidOpeningByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Bid_Opening> BidOpenings = await _procedureAdabter
               .Execute<Bid_Opening>("[Purchase].[proc_Bid_OpeningLoadByPrimaryKey]", request);
            GetBidOpeningLoadAllListVm vm = new GetBidOpeningLoadAllListVm
            {
                BidOpenings = _mapper.Map<IList<Bid_Opening>, IList<GetBidOpeningLoadAllVm>>(BidOpenings)
            };

            return vm;
        }
    }
}
