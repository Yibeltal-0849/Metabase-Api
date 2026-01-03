



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.procProportyDataCollectionTransaction.procProportyDataCollectionTransactionInsert.procProportyDataCollectionTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procProportyDataCollectionTransactionInsertHandler : IRequestHandler<procProportyDataCollectionTransactionInsertCommand, IList<Proporty_Data_Collection_TransactionID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyDataCollectionTransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_Data_Collection_TransactionID>> Handle(procProportyDataCollectionTransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_Data_Collection_TransactionID> result = await _procedureAdabter
                .Execute<Proporty_Data_Collection_TransactionID>("[ProprtyData].[proc_Proporty_Data_Collection_TransactionInsert]", request);
                                                 
           

            return result;
        }
    }
}
 