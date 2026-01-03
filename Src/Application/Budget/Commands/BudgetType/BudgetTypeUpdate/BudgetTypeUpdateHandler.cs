using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetType.BudgetTypeUpdate.BudgetTypeUpdateCommand
{ 

      public class BudgetTypeUpdateHandler : IRequestHandler<BudgetTypeUpdateCommand, IList<Budget_Type_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BudgetTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Budget_Type_Code>> Handle( BudgetTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Budget_Type_Code> result = await _procedureAdabter
                .Execute<Budget_Type_Code>("[Budget].Budget_TypeUpdate", request);
           

            return result;
        }
    }
}
 
