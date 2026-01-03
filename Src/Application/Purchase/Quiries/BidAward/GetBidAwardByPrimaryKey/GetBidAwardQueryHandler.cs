using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.BidAward.GetBidAwardLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidAward.GetBidAwardByPrimaryKey
{
    public class GetBidAwardQueryHandler : IRequestHandler<GetBidAwardByPrimaryKey, GetBidAwardLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidAwardQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidAwardLoadAllListVm> Handle(GetBidAwardByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Bid_Award> BidAwards = await _procedureAdabter
               .Execute<Bid_Award>("[Purchase].[proc_Bid_AwardLoadByPrimaryKey]", request);
            GetBidAwardLoadAllListVm vm = new GetBidAwardLoadAllListVm
            {
                BidAwards = _mapper.Map<IList<Bid_Award>, IList<GetBidAwardLoadAllVm>>(BidAwards)
            };

            return vm;
        }
    }
}
