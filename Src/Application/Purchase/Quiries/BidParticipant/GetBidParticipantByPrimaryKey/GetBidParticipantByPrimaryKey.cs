using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidParticipant.GetBidParticipantLoadAll;

namespace Application.Purchase.Quiries.BidParticipant.GetBidParticipantByPrimaryKey
{
    /// @author  Shimels Alem proc_Bid_ParticipantLoadByPrimaryKey stored procedure.

    public class GetBidParticipantByPrimaryKey : IRequest<GetBidParticipantLoadAllListVm>
    {
        public string Participant_ID { get; set; }

    }
}
