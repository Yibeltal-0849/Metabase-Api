using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.Summarized.GetSummarizedLoadAll;

namespace Application.Budget.Queries.Summarized.GetSummarizedByPrimaryKey
{
    /// @author  Shimels Alem proc_SummarizedLoadByPrimaryKey stored procedure.

    public class GetSummarizedByPrimaryKey : IRequest<GetSummarizedLoadAllListVm>
    {
        public Guid Budget_Summarized_ID { get; set; }
        public Int64 Budget_ID { get; set; }
        public string Budget_Type { get; set; }
        public Guid organization_code { get; set; }
    }
}
