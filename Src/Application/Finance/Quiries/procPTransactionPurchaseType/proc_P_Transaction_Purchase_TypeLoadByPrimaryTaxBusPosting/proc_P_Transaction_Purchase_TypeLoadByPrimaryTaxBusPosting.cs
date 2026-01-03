using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPTransactionPurchaseType.GetprocPTransactionPurchaseTypeLoadAll;

namespace Application.Finance.Quiries.procPTransactionPurchaseType.proc_P_Transaction_Purchase_TypeLoadByPrimaryTaxBusPosting
{
    /// @author  Shimels Alem [proc_P_Transaction Purchase TypeLoadByPrimaryKey] stored procedure.

    public class proc_P_Transaction_Purchase_TypeLoadByPrimaryTaxBusPosting: IRequest<GetprocPTransactionPurchaseTypeLoadAllListVm>
    {
        public string taxBusPostingGroup { get; set; }
    }
}
