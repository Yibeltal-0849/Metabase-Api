using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Budget.Queries.BudgetType.GetBudgetTypeLoadAll
{
    /// @author  Shimels Alem  proc_Budget_TypeLoadAll stored procedure.

    public class GetBudgetTypeLoadAllListVm
    {
        public IList<GetBudgetTypeLoadAllVm> BudgetTypes { get; set; }
    }
}
