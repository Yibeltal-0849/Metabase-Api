

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;



namespace Application.Budget.Commands.LetterTransaction.LetterTransactionUpdate.LetterTransactionUpdateCommand
{

    /// @author  Shimels Alem  proc_Letter_TransactionUpdate stored procedure.


    public class LetterTransactionUpdateHandler : IRequestHandler<LetterTransactionUpdateCommand, IList<LetterTransaction_Letter_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LetterTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LetterTransaction_Letter_ID>> Handle( LetterTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LetterTransaction_Letter_ID> result = await _procedureAdabter
                .Execute<LetterTransaction_Letter_ID>("[Budget].proc_Letter_TransactionUpdate", request);
           

            return result;
        }
    }
}
 