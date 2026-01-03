using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.BudgetDetailByDIV.GetBudgetDetailByDIVByPrimaryKey
{
    public class GetBudgetDetailByDIVQueryHandler : IRequestHandler<GetBudgetDetailByDIVByPrimaryKey, GetBudgetDetailByDIVLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBudgetDetailByDIVQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBudgetDetailByDIVLoadAllListVm> Handle(GetBudgetDetailByDIVByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Budget_DetailByDiv> BudgetDetailByDIVs = await _procedureAdabter
               .Execute<Budget_DetailByDiv>("[Budget].[proc_Budget_DetailByDIVLoadByPrimaryKey]", request);
            GetBudgetDetailByDIVLoadAllListVm vm = new GetBudgetDetailByDIVLoadAllListVm
            {
                BudgetDetailByDIVs = _mapper.Map<IList<Budget_DetailByDiv>, IList<GetBudgetDetailByDIVLoadAllVm>>(BudgetDetailByDIVs)
            };

            return vm;
        }
    }
}
