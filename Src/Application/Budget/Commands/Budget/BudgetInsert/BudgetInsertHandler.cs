using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Budget.BudgetInsert.BudgetInsertCommand
{ 
	 
      public class BudgetInsertHandler : IRequestHandler<BudgetInsertCommand, IList<_Budget_Budget_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BudgetInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Budget_Budget_ID>> Handle( BudgetInsertCommand request, CancellationToken cancellationToken)
        {

            IList<_Budget_Budget_ID> result = await _procedureAdabter
                .Execute<_Budget_Budget_ID>("[Budget].[BudgetInsert]", request);

            return result;
        }
    }
}
 
