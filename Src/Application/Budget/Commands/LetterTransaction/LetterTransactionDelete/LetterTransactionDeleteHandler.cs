using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.LetterTransaction.LetterTransactionDelete.LetterTransactionDeleteCommand
{ 	 
	 
      public class LetterTransactionDeleteHandler : IRequestHandler<LetterTransactionDeleteCommand, IList<LetterTransaction_Letter_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LetterTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LetterTransaction_Letter_ID>> Handle( LetterTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<LetterTransaction_Letter_ID> result = await _procedureAdabter
                .Execute<LetterTransaction_Letter_ID>("[Budget].Letter_TransactionDelete", request);
           

            return result;
        }
    }
}
 
