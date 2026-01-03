 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetEntrustTransaction.procFixedAssetEntrustTransactionDelete.procFixedAssetEntrustTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Asset_Entrust_TransactionDelete stored procedure.


    public class procFixedAssetEntrustTransactionDeleteCommand : IRequest<IList<FixedAssetEntrustTransaction_EntrustTransID>>
    {
        public System.Guid Entrust_Trans_ID { get; set; }
    }
		
     
		
		 
}
 
 