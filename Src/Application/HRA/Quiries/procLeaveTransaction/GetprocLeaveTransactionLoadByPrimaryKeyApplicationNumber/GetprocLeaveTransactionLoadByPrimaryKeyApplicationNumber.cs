using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionLoadAll;

namespace Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Leave_TransactionLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocLeaveTransactionLoadByPrimaryKeyApplicationNumber : IRequest<GetprocLeaveTransactionLoadAllListVm>
    {
        public System.Guid? Application_Code { get; set; }
    }
}
