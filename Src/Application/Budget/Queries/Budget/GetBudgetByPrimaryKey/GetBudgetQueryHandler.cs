using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Budget.Queries.Budget.GetBudgetLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.Budget.GetBudgetByPrimaryKey
{
    public class GetBudgetQueryHandler : IRequestHandler<GetBudgetByPrimaryKey, GetBudgetLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBudgetQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBudgetLoadAllListVm> Handle(GetBudgetByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_Budget> Budgets = await _procedureAdabter
               .Execute<_Budget>("[Budget].[proc_BudgetLoadByPrimaryKey]", request);
            GetBudgetLoadAllListVm vm = new GetBudgetLoadAllListVm
            {
                Budgets = _mapper.Map<IList<_Budget>, IList<GetBudgetLoadAllVm>>(Budgets)
            };

            return vm;
        }
    }
}
