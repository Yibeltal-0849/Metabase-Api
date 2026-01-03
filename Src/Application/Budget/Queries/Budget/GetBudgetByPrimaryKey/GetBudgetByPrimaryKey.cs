using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Budget.Queries.Budget.GetBudgetLoadAll;

namespace Application.Budget.Queries.Budget.GetBudgetByPrimaryKey
{
    /// @author  Shimels Alem proc_BudgetLoadByPrimaryKey stored procedure.

    public class GetBudgetByPrimaryKey : IRequest<GetBudgetLoadAllListVm>
    {
        public long Budget_ID { get; set; }
    }
}
