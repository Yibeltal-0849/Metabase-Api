using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Purchase.Quiries.BidSubmission.GetBidSubmissionLoadAll
{
    /// @author  Shimels Alem  proc_Bid_SubmissionLoadAll stored procedure.

    public class GetBidSubmissionLoadAllListVm
    {
        public IList<GetBidSubmissionLoadAllVm> BidSubmissions { get; set; }
    }
}
