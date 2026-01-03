

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.procProportyDataCollectionTransaction.procProportyDataCollectionTransactionUpdate.procProportyDataCollectionTransactionUpdateCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


    public class procProportyDataCollectionTransactionUpdateHandler : IRequestHandler<procProportyDataCollectionTransactionUpdateCommand, IList<Proporty_Data_Collection_TransactionID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyDataCollectionTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_Data_Collection_TransactionID>> Handle(procProportyDataCollectionTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_Data_Collection_TransactionID> result = await _procedureAdabter
                .Execute<Proporty_Data_Collection_TransactionID>("[ProprtyData].[proc_Proporty_Data_Collection_TransactionUpdate]", request);
           

            return result;
        }
    }
}
 