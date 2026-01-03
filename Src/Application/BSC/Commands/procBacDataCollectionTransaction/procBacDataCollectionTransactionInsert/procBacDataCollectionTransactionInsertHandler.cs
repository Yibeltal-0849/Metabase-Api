



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;


namespace Application.BSC.Commands.procBacDataCollectionTransaction.procBacDataCollectionTransactionInsert.procBacDataCollectionTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_Bac_Data_Collection_TransactionInsert stored procedure.


    public class procBacDataCollectionTransactionInsertHandler : IRequestHandler<procBacDataCollectionTransactionInsertCommand, IList<BacDataCollectionTransaction_BSCTranID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBacDataCollectionTransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BacDataCollectionTransaction_BSCTranID>> Handle( procBacDataCollectionTransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<BacDataCollectionTransaction_BSCTranID> result = await _procedureAdabter
                .Execute<BacDataCollectionTransaction_BSCTranID>("[BSC].proc_Bac_Data_Collection_TransactionInsert", request);
           

            return result;
        }
    }
}
 