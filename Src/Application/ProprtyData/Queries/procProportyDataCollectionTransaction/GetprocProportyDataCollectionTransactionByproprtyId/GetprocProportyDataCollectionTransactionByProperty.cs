using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procProportyDataCollectionTransaction.GetprocProportyDataCollectionTransactionLoadAll;

namespace Application.ProprtyData.Queries.procProportyDataCollectionTransaction.GetprocProportyDataCollectionTransactionByproprtyId
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocProportyDataCollectionTransactionByProperty : IRequest<GetprocProportyDataCollectionTransactionListVm>
    {
        public string Property_ID { get; set; }

    }
}
