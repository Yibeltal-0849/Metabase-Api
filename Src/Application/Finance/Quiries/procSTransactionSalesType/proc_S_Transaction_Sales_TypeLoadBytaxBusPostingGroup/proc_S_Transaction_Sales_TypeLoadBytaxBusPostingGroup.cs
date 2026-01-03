using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSTransactionSalesType.GetprocSTransactionSalesTypeLoadAll;

namespace Application.Finance.Quiries.procSTransactionSalesType.proc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroup
{
    /// @author  Shimels Alem [proc_S_Transaction Sales_TypeLoadByPrimaryKey] stored procedure.

    public class proc_S_Transaction_Sales_TypeLoadBytaxBusPostingGroup : IRequest<GetprocSTransactionSalesTypeLoadAllListVm>
    {
        public string taxBusPostingGroup { get; set; }
    }
}
