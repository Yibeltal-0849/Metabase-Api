using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Commands.LetterTransaction.LetterTransactionDelete.LetterTransactionDeleteCommand
{

    /// @author  Shimels Alem  proc_Letter_TransactionDelete stored procedure.


    public class LetterTransactionDeleteHandler : IRequestHandler<LetterTransactionDeleteCommand , IList<Letter_Transaction_Letter_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LetterTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Letter_Transaction_Letter_ID>> Handle( LetterTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Letter_Transaction_Letter_ID> result = await _procedureAdabter
                .Execute<Letter_Transaction_Letter_ID>("[Document].proc_Letter_TransactionDelete", request);
           

            return result;
        }
    }
}
  