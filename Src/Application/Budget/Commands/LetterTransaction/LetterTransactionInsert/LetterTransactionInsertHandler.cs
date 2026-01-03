using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.LetterTransaction.LetterTransactionInsert.LetterTransactionInsertCommand
{ 
	 
      public class LetterTransactionInsertHandler : IRequestHandler<LetterTransactionInsertCommand, IList<LetterTransaction_Letter_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LetterTransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LetterTransaction_Letter_ID>> Handle( LetterTransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<LetterTransaction_Letter_ID> result = await _procedureAdabter
                .Execute<LetterTransaction_Letter_ID>("[Budget].Letter_TransactionInsert", request);
           

            return result;
        }
    }
}
 
