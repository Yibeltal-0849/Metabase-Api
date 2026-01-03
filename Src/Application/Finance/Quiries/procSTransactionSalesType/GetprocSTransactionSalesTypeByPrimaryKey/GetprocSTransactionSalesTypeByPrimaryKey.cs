using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSTransactionSalesType.GetprocSTransactionSalesTypeLoadAll;

namespace Application.Finance.Quiries.procSTransactionSalesType.GetprocSTransactionSalesTypeByPrimaryKey
{
    /// @author  Shimels Alem [proc_S_Transaction Sales_TypeLoadByPrimaryKey] stored procedure.

    public class GetprocSTransactionSalesTypeByPrimaryKey : IRequest<GetprocSTransactionSalesTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
