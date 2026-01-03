using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPPurchasequote.GetprocPPurchasequoteLoadAll;

namespace Application.Finance.Quiries.procPPurchasequote.GetprocPPurchasequoteByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Purchase quoteLoadByPrimaryKey] stored procedure.

    public class GetprocPPurchasequoteByPrimaryKey : IRequest<GetprocPPurchasequoteLoadAllListVm>
    {
        public System.Guid Purchase_Line { get; set; }
    }
}
