using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCTransactionSales.GetprocCTransactionSalesLoadAll;

namespace Application.Finance.Quiries.procCTransactionSales.GetprocCTransactionSalesByPrimaryKey
{
    /// @author  Shimels Alem proc_CTransaction_SalesLoadByPrimaryKey stored procedure.

    public class GetprocCTransactionSalesByPrimaryKey : IRequest<GetprocCTransactionSalesLoadAllListVm>
    {
        public string No { get; set; }
    }
}
