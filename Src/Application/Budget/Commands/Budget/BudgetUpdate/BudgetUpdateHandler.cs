using Application.Budget.Commands.Budget.BudgetInsert.BudgetInsertCommand;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Budget.BudgetUpdate.BudgetUpdateCommand
{ 

      public class BudgetUpdateHandler : IRequestHandler<BudgetUpdateCommand, IList<_Budget_Budget_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BudgetUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Budget_Budget_ID>> Handle( BudgetUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<_Budget_Budget_ID> result = await _procedureAdabter
                .Execute<_Budget_Budget_ID>("[Budget].BudgetUpdate", request);

            return result;
        }
    }
}
 
