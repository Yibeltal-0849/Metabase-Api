using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPPurchasecreditmemo.GetprocPPurchasecreditmemoLoadAll;

namespace Application.Finance.Quiries.procPPurchasecreditmemo.GetprocPPurchasecreditmemoByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Purchase credit memoLoadByPrimaryKey] stored procedure.

    public class GetprocPPurchasecreditmemoByPrimaryKey : IRequest<GetprocPPurchasecreditmemoLoadAllListVm>
    {
        public System.Guid Purchase_Line { get; set; }
    }
}
