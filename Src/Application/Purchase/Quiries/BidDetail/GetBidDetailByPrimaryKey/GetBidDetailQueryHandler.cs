using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.BidDetail.GetBidDetailLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.BidDetail.GetBidDetailByPrimaryKey
{
    public class GetBidDetailQueryHandler : IRequestHandler<GetBidDetailByPrimaryKey_BIDID, GetBidDetailLoadAllVm_BIDID>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBidDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBidDetailLoadAllVm_BIDID> Handle(GetBidDetailByPrimaryKey_BIDID request, CancellationToken cancellationToken)
        {
            //[Purchase].[proc_Bid_DetailLoadByPrimaryKey]
            IList<Bid_Detail> BidDetails = await _procedureAdabter
               .Execute<Bid_Detail>("[Purchase].[proc_Bid_DetailLoadByPrimaryKey_BIDID]", request);
            GetBidDetailLoadAllVm_BIDID vm = new GetBidDetailLoadAllVm_BIDID
            {
                BidID = _mapper.Map<IList<Bid_Detail>, IList<GetBidDetailLoadAllVm>>(BidDetails)
            };

            return vm;
        }
    }
}
