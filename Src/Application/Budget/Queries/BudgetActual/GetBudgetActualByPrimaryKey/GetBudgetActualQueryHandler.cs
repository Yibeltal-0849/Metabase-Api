using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Budget.Queries.BudgetActual.GetBudgetActualLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.BudgetActual.GetBudgetActualByPrimaryKey
{
    public class GetBudgetActualQueryHandler : IRequestHandler<GetBudgetActualByPrimaryKey, GetBudgetActualLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBudgetActualQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBudgetActualLoadAllListVm> Handle(GetBudgetActualByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Budget_Actual> BudgetActuals = await _procedureAdabter
               .Execute<Budget_Actual>("[Budget].[proc_Budget_ActualLoadByPrimaryKey]", request);
            GetBudgetActualLoadAllListVm vm = new GetBudgetActualLoadAllListVm
            {
                BudgetActuals = _mapper.Map<IList<Budget_Actual>, IList<GetBudgetActualLoadAllVm>>(BudgetActuals)
            };

            return vm;
        }
    }
}
