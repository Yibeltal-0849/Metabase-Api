using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.BudgetType.GetBudgetTypeLoadAll;

namespace Application.Budget.Queries.BudgetType.GetBudgetTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Budget_TypeLoadByPrimaryKey stored procedure.

    public class GetBudgetTypeByPrimaryKey : IRequest<GetBudgetTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
