using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.procBacDataCollectionTransaction.procBacDataCollectionTransactionDelete.procBacDataCollectionTransactionDeleteCommand
{

    /// @author  Shimels Alem  proc_Bac_Data_Collection_TransactionDelete stored procedure.


    public class procBacDataCollectionTransactionDeleteHandler : IRequestHandler<procBacDataCollectionTransactionDeleteCommand, IList<BacDataCollectionTransaction_BSCTranID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBacDataCollectionTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BacDataCollectionTransaction_BSCTranID>> Handle( procBacDataCollectionTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BacDataCollectionTransaction_BSCTranID> result = await _procedureAdabter
                .Execute<BacDataCollectionTransaction_BSCTranID>("[BSC].proc_Bac_Data_Collection_TransactionDelete", request);
           

            return result;
        }
    }
}
  