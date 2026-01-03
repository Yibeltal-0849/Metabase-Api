using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCTransactionSales.GetprocCTransactionSalesLoadAll;

namespace Application.Finance.Quiries.procCTransactionSales.GetprocCTransactionSalesLoadByPrimaryKeyApplicationNo
{
    /// @author  Shimels Alem proc_CTransaction_SalesLoadByPrimaryKey_Application_No stored procedure.

    public class GetprocCTransactionSalesLoadByPrimaryKeyApplicationNo : IRequest<GetprocCTransactionSalesLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
