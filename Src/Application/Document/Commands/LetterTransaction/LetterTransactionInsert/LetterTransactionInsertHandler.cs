



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;


namespace Application.Document.Commands.LetterTransaction.LetterTransactionInsert.LetterTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_Letter_TransactionInsert stored procedure.


    public class LetterTransactionInsertHandler : IRequestHandler<LetterTransactionInsertCommand, IList<Letter_Transaction_Letter_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LetterTransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Letter_Transaction_Letter_ID>> Handle( LetterTransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Letter_Transaction_Letter_ID> result = await _procedureAdabter
                .Execute<Letter_Transaction_Letter_ID>("[Document].proc_Letter_TransactionInsert", request);
           

            return result;
        }
    }
}
 