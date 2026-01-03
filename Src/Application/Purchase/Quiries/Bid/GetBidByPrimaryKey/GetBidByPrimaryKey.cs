using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.Bid.GetBidLoadAll;

namespace Application.Purchase.Quiries.Bid.GetBidByPrimaryKey
{
    /// @author  Shimels Alem proc_BidLoadByPrimaryKey stored procedure.

    public class GetBidByPrimaryKey : IRequest<GetBidLoadAllListVm>
    {
        public System.Guid Bid_ID { get; set; }
    }
}
