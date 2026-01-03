using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Purchase.Quiries.BidOpening.GetBidOpeningLoadAll
{
    /// @author  Shimels Alem  proc_Bid_OpeningLoadAll stored procedure.

    public class GetBidOpeningLoadAllListVm
    {
        public IList<GetBidOpeningLoadAllVm> BidOpenings { get; set; }
    }
}
