using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVLoadAll
{
    /// @author  Shimels Alem  proc_Budget_DetailByDIVLoadAll stored procedure.

    public class GetBudgetDetailByDIVLoadAllListVm
    {
        public IList<GetBudgetDetailByDIVLoadAllVm> BudgetDetailByDIVs { get; set; }
    }
}
