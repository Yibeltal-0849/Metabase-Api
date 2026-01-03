using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Budget.Queries.BudgetType.GetBudgetTypeLoadAll
{
    public class GetBudgetTypeLoadAllQuery : IRequest<GetBudgetTypeLoadAllListVm>
    {
    }
}
