using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPTransactionPurchaseType.GetprocPTransactionPurchaseTypeLoadAll;

namespace Application.Finance.Quiries.procPTransactionPurchaseType.GetprocPTransactionPurchaseTypeByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Transaction Purchase TypeLoadByPrimaryKey] stored procedure.

    public class GetprocPTransactionPurchaseTypeByPrimaryKey : IRequest<GetprocPTransactionPurchaseTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
