using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVLoadAll;

namespace Application.Budget.Queries.BudgetDetailByDIV.GetprocBudgetDetailByDIVLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Budget_DetailByDIVLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocBudgetDetailByDIVLoadByPrimaryKeyApplicationNumber : IRequest<GetBudgetDetailByDIVLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
