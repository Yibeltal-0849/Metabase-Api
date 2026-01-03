using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetActual.BudgetActualDelete.BudgetActualDeleteCommand
{ 	 
	 
      public class BudgetActualDeleteHandler : IRequestHandler<BudgetActualDeleteCommand, IList<Budget_Actual_Budget_ActualID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BudgetActualDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Budget_Actual_Budget_ActualID>> Handle( BudgetActualDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Budget_Actual_Budget_ActualID> result = await _procedureAdabter
                .Execute<Budget_Actual_Budget_ActualID>("[Budget].Budget_ActualDelete", request);
           

            return result;
        }
    }
}
 
