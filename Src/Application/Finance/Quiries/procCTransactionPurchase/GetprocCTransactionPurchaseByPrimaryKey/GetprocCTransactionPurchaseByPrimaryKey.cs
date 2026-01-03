using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseLoadAll;

namespace Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseByPrimaryKey
{
    /// @author  Shimels Alem proc_CTransaction_PurchaseLoadByPrimaryKey stored procedure.

    public class GetprocCTransactionPurchaseByPrimaryKey : IRequest<GetprocCTransactionPurchaseLoadAllListVm>
    {
        public string No { get; set; }
    }
}
