using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyDataCollectionTransaction.procProportyDataCollectionTransactionDelete.procProportyDataCollectionTransactionDeleteCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyDataCollectionTransactionDeleteHandler : IRequestHandler<procProportyDataCollectionTransactionDeleteCommand, IList<Proporty_Data_Collection_TransactionID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyDataCollectionTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_Data_Collection_TransactionID>> Handle(procProportyDataCollectionTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_Data_Collection_TransactionID> result = await _procedureAdabter
                .Execute<Proporty_Data_Collection_TransactionID>("[ProprtyData].[proc_Proporty_Data_Collection_TransactionDelete]", request);
           

            return result;
        }
    }
}
  