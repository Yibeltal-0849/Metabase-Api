using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidOpening.GetBidOpeningLoadAll;

namespace Application.Purchase.Quiries.BidOpening.GetBidOpeningByPrimaryKey
{
    /// @author  Shimels Alem proc_Bid_OpeningLoadByPrimaryKey stored procedure.

    public class GetBidOpeningByPrimaryKey : IRequest<GetBidOpeningLoadAllListVm>
    {
        public string Participant_ID { get; set; }
    }
}
