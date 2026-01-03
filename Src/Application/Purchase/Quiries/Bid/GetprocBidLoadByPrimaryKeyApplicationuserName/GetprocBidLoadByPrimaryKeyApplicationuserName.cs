using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.Bid.GetBidLoadAll;

namespace Application.Purchase.Quiries.Bid.GetprocBidLoadByPrimaryKeyApplicationuserName
{
    /// @author  Shimels Alem proc_BidLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocBidLoadByPrimaryKeyApplicationuserName : IRequest<GetBidLoadAllListVm>
    {
        //public string application_No { get; set; }
        public System.Guid UserId { get; set; }
    }
}
