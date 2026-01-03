 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyDataCollectionTransaction.procProportyDataCollectionTransactionDelete.procProportyDataCollectionTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyDataCollectionTransactionDeleteCommand : IRequest<IList<Proporty_Data_Collection_TransactionID>>
    {
        public System.Guid Trans_ID { get; set; }
      
    }
		
     
		
		 
}
 
 