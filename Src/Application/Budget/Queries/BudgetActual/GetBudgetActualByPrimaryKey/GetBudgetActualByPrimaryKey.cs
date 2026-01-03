using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.BudgetActual.GetBudgetActualLoadAll;

namespace Application.Budget.Queries.BudgetActual.GetBudgetActualByPrimaryKey
{
    /// @author  Shimels Alem proc_Budget_ActualLoadByPrimaryKey stored procedure.

    public class GetBudgetActualByPrimaryKey : IRequest<GetBudgetActualLoadAllListVm>
    {
        public long Budget_ActualID { get; set; }
    }
}
