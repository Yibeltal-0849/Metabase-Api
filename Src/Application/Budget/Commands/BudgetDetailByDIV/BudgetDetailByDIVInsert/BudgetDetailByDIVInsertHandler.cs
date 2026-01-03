using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetDetailByDIV.BudgetDetailByDIVInsert.BudgetDetailByDIVInsertCommand
{ 
	 
      public class BudgetDetailByDIVInsertHandler : IRequestHandler<BudgetDetailByDIVInsertCommand, IList<Budget_DetailByDiv_Budget_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BudgetDetailByDIVInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Budget_DetailByDiv_Budget_DetailID>> Handle( BudgetDetailByDIVInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Budget_DetailByDiv_Budget_DetailID> result = await _procedureAdabter
                .Execute<Budget_DetailByDiv_Budget_DetailID>("[Budget].Budget_DetailByDIVInsert", request);
           

            return result;
        }
    }
}
 
