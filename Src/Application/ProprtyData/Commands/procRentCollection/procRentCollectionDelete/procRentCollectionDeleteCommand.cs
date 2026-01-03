 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollection.procRentCollectionDelete.procRentCollectionDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procRentCollectionDeleteCommand : IRequest<IList<RentCollection_Month>>
    {
        public System.Guid Month { get; set; }
        public System.Guid Rent_Collection_ID { get; set; }
        public System.Guid Rent_Contract_ID { get; set; }
    }
		
     
		
		 
}
 
 