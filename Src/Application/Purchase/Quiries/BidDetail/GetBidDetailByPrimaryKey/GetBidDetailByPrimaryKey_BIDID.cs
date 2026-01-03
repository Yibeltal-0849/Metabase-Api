using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidDetail.GetBidDetailLoadAll;

namespace Application.Purchase.Quiries.BidDetail.GetBidDetailByPrimaryKey
{

    public class GetBidDetailByPrimaryKey_BIDID : IRequest<GetBidDetailLoadAllVm_BIDID>
    {
        public System.Guid Bid_ID { get; set;}
    }
}
