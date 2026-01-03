using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.Budget.GetBudgetLoadAll;

namespace Application.Budget.Queries.Budget.GetprocBudgetLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_BudgetLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocBudgetLoadByPrimaryKeyApplicationNumber : IRequest<GetBudgetLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
