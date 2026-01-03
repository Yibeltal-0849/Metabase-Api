

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;



namespace Application.BSC.Commands.procBacDataCollectionTransaction.procBacDataCollectionTransactionUpdate.procBacDataCollectionTransactionUpdateCommand
{

    /// @author  Shimels Alem  proc_Bac_Data_Collection_TransactionUpdate stored procedure.


    public class procBacDataCollectionTransactionUpdateHandler : IRequestHandler<procBacDataCollectionTransactionUpdateCommand, IList<BacDataCollectionTransaction_BSCTranID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBacDataCollectionTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BacDataCollectionTransaction_BSCTranID>> Handle( procBacDataCollectionTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<BacDataCollectionTransaction_BSCTranID> result = await _procedureAdabter
                .Execute<BacDataCollectionTransaction_BSCTranID>("[BSC].[proc_Bac_Data_Collection_TransactionUpdate]", request);
           

            return result;
        }
    }
}
 