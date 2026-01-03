using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionLoadAll;

namespace Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Payrole_TransactionLoadByPrimaryKey_Appilcation_Number  stored procedure.

    public class GetprocPayroleTransactionLoadByPrimaryKeyApplicationNumber : IRequest<GetprocPayroleTransactionLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
