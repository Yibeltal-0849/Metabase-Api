using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidParticipant.GetBidParticipantLoadAll;

namespace Application.Purchase.Quiries.BidParticipant.GetBidParticipantByPrimaryKey
{
    public class GetBidParticipantByPrimaryKey_By_Bid_DetailID : IRequest<GetBidParticipantLoadAllListVm_Bid_DetailID>
    {
        public Guid Bid_DetailID { get; set; }
    }
}
