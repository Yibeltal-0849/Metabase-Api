using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.BudgetActual.GetBudgetActualLoadAll;

namespace Application.Budget.Queries.BudgetActual.GetprocBudgetActualLoadByPrimaryKeyBudgetDetailID
{
    /// @author  Shimels Alem proc_Budget_ActualLoadByPrimaryKey_Budget_DetailID stored procedure.

    public class GetprocBudgetActualLoadByPrimaryKeyBudgetDetailID : IRequest<GetBudgetActualLoadAllListVm>
    {
        public string Budget_DetailID { get; set; }
    }
}
