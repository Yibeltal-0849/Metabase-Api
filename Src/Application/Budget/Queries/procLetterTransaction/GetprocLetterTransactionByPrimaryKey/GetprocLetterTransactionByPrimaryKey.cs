using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Quiries.procLetterTransaction.GetprocLetterTransactionLoadAll;

namespace Application.Budget.Quiries.procLetterTransaction.GetprocLetterTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Letter_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocLetterTransactionByPrimaryKey : IRequest<GetprocLetterTransactionLoadAllListVm>
    {
        public Guid Letter_ID { get; set; }
    }
}
