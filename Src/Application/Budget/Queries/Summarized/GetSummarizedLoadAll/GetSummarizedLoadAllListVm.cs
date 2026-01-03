using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Budget.Queries.Summarized.GetSummarizedLoadAll
{
    /// @author  Shimels Alem  proc_SummarizedLoadAll stored procedure.

    public class GetSummarizedLoadAllListVm
    {
        public IList<GetSummarizedLoadAllVm> Summarizeds { get; set; }
    }
}
