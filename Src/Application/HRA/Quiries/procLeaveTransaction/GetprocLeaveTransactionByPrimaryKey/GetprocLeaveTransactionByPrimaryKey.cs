using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionLoadAll;

namespace Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Leave_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocLeaveTransactionByPrimaryKey : IRequest<GetprocLeaveTransactionLoadAllListVm>
    {
        public System.Guid Leave_Tran_ID { get; set; }
    }
}
