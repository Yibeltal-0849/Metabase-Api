using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidAward.GetBidAwardLoadAll
{
    class GetBidAwardLoadAllQueryHandler : IRequestHandler<GetBidAwardLoadAllQuery, GetBidAwardLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBidAwardLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidAwardLoadAllListVm> Handle(GetBidAwardLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Bid_Award> BidAwards = await _procedureAdabter
               .Execute<Bid_Award>("[Purchase].[proc_Bid_AwardLoadAll]");
            GetBidAwardLoadAllListVm vm = new GetBidAwardLoadAllListVm
            {
                BidAwards = _mapper.Map<IList<Bid_Award>, IList<GetBidAwardLoadAllVm>>(BidAwards)
            };

            return vm;
        }
    }
}
