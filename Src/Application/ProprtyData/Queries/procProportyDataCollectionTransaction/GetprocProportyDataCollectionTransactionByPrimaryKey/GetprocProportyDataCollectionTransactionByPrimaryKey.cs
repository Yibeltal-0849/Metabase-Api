using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procProportyDataCollectionTransaction.GetprocProportyDataCollectionTransactionLoadAll;

namespace Application.ProprtyData.Queries.procProportyDataCollectionTransaction.GetprocProportyDataCollectionTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocProportyDataCollectionTransactionByPrimaryKey : IRequest<GetprocProportyDataCollectionTransactionListVm>
    {
        public System.Guid Trans_ID { get; set; }
        
    }
}
