using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Budget.Queries.BudgetActual.GetBudgetActualLoadAll
{
    /// @author  Shimels Alem  proc_Budget_ActualLoadAll stored procedure.

    public class GetBudgetActualLoadAllListVm
    {
        public IList<GetBudgetActualLoadAllVm> BudgetActuals { get; set; }
    }
}
