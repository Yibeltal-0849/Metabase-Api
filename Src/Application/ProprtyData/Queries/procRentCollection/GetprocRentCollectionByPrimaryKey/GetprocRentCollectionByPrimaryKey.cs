using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procRentCollection.GetprocRentCollectionLoadAll;

namespace Application.ProprtyData.Queries.procRentCollection.GetprocRentCollectionByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocRentCollectionByPrimaryKey : IRequest<GetprocRentCollectionLoadAllListVm>
    {
        public System.Guid Month { get; set; }
        public System.Guid Rent_Collection_ID { get; set; }
        public System.Guid Rent_Contract_ID { get; set; }
    }
}
