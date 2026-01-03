using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVLoadAll;

namespace Application.Budget.Queries.BudgetDetailByDIV.GetprocBudgetDetailByDIVLoadByPrimaryKeyBudgetID
{
    /// @author  Shimels Alem proc_Budget_DetailByDIVLoadByPrimaryKey_Budget_ID stored procedure.

    public class GetprocBudgetDetailByDIVLoadByPrimaryKeyBudgetID : IRequest<GetBudgetDetailByDIVLoadAllListVm>
    {
        public long Budget_ID { get; set; }
    }
}
