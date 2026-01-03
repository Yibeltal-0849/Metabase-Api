 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.procBacDataCollectionTransaction.procBacDataCollectionTransactionDelete.procBacDataCollectionTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_Bac_Data_Collection_TransactionDelete stored procedure.


    public class procBacDataCollectionTransactionDeleteCommand : IRequest<IList<BacDataCollectionTransaction_BSCTranID>>
    {
        public System.Guid Bsc_Tran_Data_Id { get; set; }
    }
		
     
		
		 
}
 
 