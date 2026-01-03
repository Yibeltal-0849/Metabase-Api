using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidResult.GetBidResultLoadAll;

namespace Application.Purchase.Quiries.BidResult.GetBidResultByPrimaryKey
{
    /// @author  Shimels Alem proc_Bid_ResultLoadByPrimaryKey stored procedure.

    public class GetBidResultByPrimaryKey : IRequest<GetBidResultLoadAllListVm>
    {
        public System.Guid Bid_Result { get; set; }
    }
}
