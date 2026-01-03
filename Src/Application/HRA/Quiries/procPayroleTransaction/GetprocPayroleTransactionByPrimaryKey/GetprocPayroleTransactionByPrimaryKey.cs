using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionLoadAll;

namespace Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Payrole_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocPayroleTransactionByPrimaryKey : IRequest<GetprocPayroleTransactionLoadAllListVm>
    {
        public System.Guid Payrole_Trans_Id { get; set; }
    }
}
