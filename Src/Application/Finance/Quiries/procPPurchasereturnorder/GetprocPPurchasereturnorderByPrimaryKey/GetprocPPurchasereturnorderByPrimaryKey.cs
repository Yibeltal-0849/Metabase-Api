using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPPurchasereturnorder.GetprocPPurchasereturnorderLoadAll;

namespace Application.Finance.Quiries.procPPurchasereturnorder.GetprocPPurchasereturnorderByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Purchase return orderLoadByPrimaryKey] stored procedure.

    public class GetprocPPurchasereturnorderByPrimaryKey : IRequest<GetprocPPurchasereturnorderLoadAllListVm>
    {
        public System.Guid Purchase_Line { get; set; }
    }
}
