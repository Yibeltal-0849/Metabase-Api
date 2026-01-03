using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidSubmission.GetBidSubmissionLoadAll;

namespace Application.Purchase.Quiries.BidSubmission.GetprocBidSubmissionLoadByPrimaryKeyPrticipantID
{
    /// @author  Shimels Alem proc_Bid_SubmissionLoadByPrimaryKey_Prticipant_ID stored procedure.

    public class GetprocBidSubmissionLoadByPrimaryKeyPrticipantID : IRequest<GetBidSubmissionLoadAllListVm>
    {
        public string Participant_ID { get; set; }
    }
}
