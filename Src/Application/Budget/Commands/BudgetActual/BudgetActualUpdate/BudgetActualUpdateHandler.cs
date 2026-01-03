using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetActual.BudgetActualUpdate.BudgetActualUpdateCommand
{ 

      public class BudgetActualUpdateHandler : IRequestHandler<BudgetActualUpdateCommand, IList<Budget_Actual_Budget_ActualID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BudgetActualUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Budget_Actual_Budget_ActualID>> Handle( BudgetActualUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Budget_Actual_Budget_ActualID> result = await _procedureAdabter
                .Execute<Budget_Actual_Budget_ActualID>("[Budget].Budget_ActualUpdate", request);
           

            return result;
        }
    }
}
 
