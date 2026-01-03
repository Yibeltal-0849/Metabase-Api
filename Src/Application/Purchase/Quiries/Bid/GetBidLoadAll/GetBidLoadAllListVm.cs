using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Purchase.Quiries.Bid.GetBidLoadAll
{
    /// @author  Shimels Alem  proc_BidLoadAll stored procedure.

    public class GetBidLoadAllListVm
    {
        public IList<GetBidLoadAllVm> Bids { get; set; }
    }
}
