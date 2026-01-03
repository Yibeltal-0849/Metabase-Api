 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.procFixedAssetMaintTransaction.procFixedAssetMaintTransactionDelete.procFixedAssetMaintTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Asset_Maint_TransactionDelete stored procedure.


    public class procFixedAssetMaintTransactionDeleteCommand : IRequest<IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>>
    {
        public System.Guid FixedAsset_Maintan_Trans_ID { get; set; }
    }
		
     
		
		 
}
 
 