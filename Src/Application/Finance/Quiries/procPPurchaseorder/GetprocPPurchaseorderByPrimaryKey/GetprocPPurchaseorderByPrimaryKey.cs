using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPPurchaseorder.GetprocPPurchaseorderLoadAll;

namespace Application.Finance.Quiries.procPPurchaseorder.GetprocPPurchaseorderByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Purchase orderLoadByPrimaryKey] stored procedure.

    public class GetprocPPurchaseorderByPrimaryKey : IRequest<GetprocPPurchaseorderLoadAllListVm>
    {
        public System.Guid Purchase_Line_ID { get; set; }
    }
}
