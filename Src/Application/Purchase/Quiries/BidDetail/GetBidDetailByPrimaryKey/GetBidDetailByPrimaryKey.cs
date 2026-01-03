using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidDetail.GetBidDetailLoadAll;

namespace Application.Purchase.Quiries.BidDetail.GetBidDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Bid_DetailLoadByPrimaryKey stored procedure.

    public class GetBidDetailByPrimaryKey : IRequest<GetBidDetailLoadAllListVm>
    {
        public System.Guid Bid_DetailID { get; set; }


    }
}
