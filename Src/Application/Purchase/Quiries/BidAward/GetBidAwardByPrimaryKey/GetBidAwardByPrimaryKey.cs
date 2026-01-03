using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidAward.GetBidAwardLoadAll;

namespace Application.Purchase.Quiries.BidAward.GetBidAwardByPrimaryKey
{
    /// @author  Shimels Alem proc_Bid_AwardLoadByPrimaryKey stored procedure.

    public class GetBidAwardByPrimaryKey : IRequest<GetBidAwardLoadAllListVm>
    {
        public System.Guid Bid_Award_ID { get; set; }
    }
}
