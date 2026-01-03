using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidDetail.GetBidDetailLoadAll
{
    class GetBidDetailLoadAllQueryHandler : IRequestHandler<GetBidDetailLoadAllQuery, GetBidDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidDetailLoadAllListVm> Handle(GetBidDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Bid_Detail> BidDetails = await _procedureAdabter
               .Execute<Bid_Detail>("[Purchase].[proc_Bid_DetailLoadAll]");
            GetBidDetailLoadAllListVm vm = new GetBidDetailLoadAllListVm
            {
                BidDetails = _mapper.Map<IList<Bid_Detail>, IList<GetBidDetailLoadAllVm>>(BidDetails)
            };

            return vm;
        }
    }
}
