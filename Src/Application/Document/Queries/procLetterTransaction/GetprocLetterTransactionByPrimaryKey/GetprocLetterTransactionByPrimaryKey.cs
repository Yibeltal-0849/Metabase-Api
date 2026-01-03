using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Document.Quiries.procLetterTransaction.GetprocLetterTransactionLoadAll;

namespace Application.Document.Quiries.procLetterTransaction.GetprocLetterTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Letter_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocLetterTransactionByPrimaryKey : IRequest<GetprocLetterTransactionLoadAllListVm>
    {
        public System.Guid Letter_ID { get; set; }
    }
}
