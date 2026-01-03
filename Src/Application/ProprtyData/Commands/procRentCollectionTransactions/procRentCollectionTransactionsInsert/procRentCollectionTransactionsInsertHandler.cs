



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;


namespace Application.ProprtyData.Commands.procRentCollectionTransactions.procRentCollectionTransactionsInsert.procRentCollectionTransactionsInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_Collection_TransactionsInsert stored procedure.


    public class procRentCollectionTransactionsInsertHandler : IRequestHandler<procRentCollectionTransactionsInsertCommand, IList<RentCollectionTransactions>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRentCollectionTransactionsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentCollectionTransactions>> Handle( procRentCollectionTransactionsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<RentCollectionTransactions> result = await _procedureAdabter
                .Execute<RentCollectionTransactions>("[ProprtyData].proc_Rent_Collection_TransactionsInsert", request);
           

            return result;
        }
    }
}
 