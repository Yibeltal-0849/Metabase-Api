using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVLoadAll
{
    class GetBudgetDetailByDIVLoadAllQueryHandler : IRequestHandler<GetBudgetDetailByDIVLoadAllQuery, GetBudgetDetailByDIVLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBudgetDetailByDIVLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBudgetDetailByDIVLoadAllListVm> Handle(GetBudgetDetailByDIVLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Budget_DetailByDiv> BudgetDetailByDIVs = await _procedureAdabter
               .Execute<Budget_DetailByDiv>("[Budget].[proc_Budget_DetailByDIVLoadAll]");
            GetBudgetDetailByDIVLoadAllListVm vm = new GetBudgetDetailByDIVLoadAllListVm
            {
                BudgetDetailByDIVs = _mapper.Map<IList<Budget_DetailByDiv>, IList<GetBudgetDetailByDIVLoadAllVm>>(BudgetDetailByDIVs)
            };

            return vm;
        }
    }
}
