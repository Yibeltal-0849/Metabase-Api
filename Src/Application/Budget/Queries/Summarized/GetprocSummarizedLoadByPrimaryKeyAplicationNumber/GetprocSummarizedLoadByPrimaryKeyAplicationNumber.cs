using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.Summarized.GetSummarizedLoadAll;

namespace Application.Budget.Queries.Summarized.GetprocSummarizedLoadByPrimaryKeyAplicationNumber
{
    /// @author  Shimels Alem proc_SummarizedLoadByPrimaryKey_Aplication_Number stored procedure.

    public class GetprocSummarizedLoadByPrimaryKeyAplicationNumber : IRequest<GetSummarizedLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
