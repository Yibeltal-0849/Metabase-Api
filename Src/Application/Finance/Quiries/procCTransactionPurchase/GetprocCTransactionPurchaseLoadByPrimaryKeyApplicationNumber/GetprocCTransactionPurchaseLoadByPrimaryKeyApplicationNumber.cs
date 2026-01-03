using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseLoadAll;

namespace Application.Finance.Quiries.procCTransactionPurchase.GetprocCTransactionPurchaseLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_CTransaction_PurchaseLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocCTransactionPurchaseLoadByPrimaryKeyApplicationNumber : IRequest<GetprocCTransactionPurchaseLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
