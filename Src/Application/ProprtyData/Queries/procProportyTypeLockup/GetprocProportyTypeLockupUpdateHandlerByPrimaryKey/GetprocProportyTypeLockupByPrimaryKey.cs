using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procProportyTypeLockup.GetprocProportyTypeLockupHandlerLoadAll;

namespace Application.ProprtyData.Queries.procProportyTypeLockup.GetprocProportyDataCollectionTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocProportyTypeLockupByPrimaryKey : IRequest<GetprocProportyTypeLockupListVm>
    {
        public int Property_Type_ID { get; set; }
      


    }
}
