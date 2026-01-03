using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Budget.Queries.Budget.GetBudgetLoadAll
{
    /// @author  Shimels Alem  proc_BudgetLoadAll stored procedure.

    public class GetBudgetLoadAllListVm
    {
        public IList<GetBudgetLoadAllVm> Budgets { get; set; }
    }
}
