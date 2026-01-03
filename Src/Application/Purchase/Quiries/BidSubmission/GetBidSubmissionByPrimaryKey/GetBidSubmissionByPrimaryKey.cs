using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.BidSubmission.GetBidSubmissionLoadAll;

namespace Application.Purchase.Quiries.BidSubmission.GetBidSubmissionByPrimaryKey
{
    /// @author  Shimels Alem proc_Bid_SubmtionLoadByPrimaryKey stored procedure.

    public class GetBidSubmissionByPrimaryKey : IRequest<GetBidSubmissionLoadAllListVm>
    {
        public string Participant_ID { get; set; }
    }
}
