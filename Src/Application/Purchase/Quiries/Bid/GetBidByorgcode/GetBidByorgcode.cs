using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.Bid.GetBidLoadAll;

namespace Application.Purchase.Quiries.Bid.GetBidByorgcode
{
    public class GetBidByorgcode : IRequest<GetBidLoadorgcodeListVm>
    {
        public System.Guid organization_code { get; set; }
    }
}
