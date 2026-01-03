using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.Bid.GetBidLoadAll;

namespace Application.Purchase.Quiries.Bid.GetBprocBidLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_BidLoadByPrimaryKey_Application_Number stored procedure.

    public class GetBprocBidLoadByPrimaryKeyApplicationNumber : IRequest<GetBidLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
