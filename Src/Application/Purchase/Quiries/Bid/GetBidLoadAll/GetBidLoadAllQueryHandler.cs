using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.Bid.GetBidLoadAll
{
    class GetBidLoadAllQueryHandler : IRequestHandler<GetBidLoadAllQuery, GetBidLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidLoadAllListVm> Handle(GetBidLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Bid> Bids = await _procedureAdabter
               .Execute<_Bid>("[Purchase].[proc_BidLoadAll]");
            GetBidLoadAllListVm vm = new GetBidLoadAllListVm
            {
                Bids = _mapper.Map<IList<_Bid>, IList<GetBidLoadAllVm>>(Bids)
            };

            return vm;
        }
    }
}
