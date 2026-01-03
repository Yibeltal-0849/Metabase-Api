using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidOpening.GetBidOpeningLoadAll
{
    class GetBidOpeningLoadAllQueryHandler : IRequestHandler<GetBidOpeningLoadAllQuery, GetBidOpeningLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidOpeningLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidOpeningLoadAllListVm> Handle(GetBidOpeningLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Bid_Opening> BidOpenings = await _procedureAdabter
               .Execute<Bid_Opening>("[Purchase].[proc_Bid_OpeningLoadAll]");
            GetBidOpeningLoadAllListVm vm = new GetBidOpeningLoadAllListVm
            {
                BidOpenings = _mapper.Map<IList<Bid_Opening>, IList<GetBidOpeningLoadAllVm>>(BidOpenings)
            };

            return vm;
        }
    }
}
