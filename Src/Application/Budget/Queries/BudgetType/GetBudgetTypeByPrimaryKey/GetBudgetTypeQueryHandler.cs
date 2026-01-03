using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Budget.Queries.BudgetType.GetBudgetTypeLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.BudgetType.GetBudgetTypeByPrimaryKey
{
    public class GetBudgetTypeQueryHandler : IRequestHandler<GetBudgetTypeByPrimaryKey, GetBudgetTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBudgetTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBudgetTypeLoadAllListVm> Handle(GetBudgetTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Budget_Type> BudgetTypes = await _procedureAdabter
               .Execute<Budget_Type>("[Budget].[proc_Budget_TypeLoadByPrimaryKey]", request);
            GetBudgetTypeLoadAllListVm vm = new GetBudgetTypeLoadAllListVm
            {
                BudgetTypes = _mapper.Map<IList<Budget_Type>, IList<GetBudgetTypeLoadAllVm>>(BudgetTypes)
            };

            return vm;
        }
    }
}
