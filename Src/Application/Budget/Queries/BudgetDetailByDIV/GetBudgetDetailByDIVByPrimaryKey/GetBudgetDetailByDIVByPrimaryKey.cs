using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVLoadAll;

namespace Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVByPrimaryKey
{
    /// @author  Shimels Alem proc_Budget_DetailByDIVLoadByPrimaryKey stored procedure.

    public class GetBudgetDetailByDIVByPrimaryKey : IRequest<GetBudgetDetailByDIVLoadAllListVm>
    {
        public string Budget_DetailID { get; set; }
    }
}
