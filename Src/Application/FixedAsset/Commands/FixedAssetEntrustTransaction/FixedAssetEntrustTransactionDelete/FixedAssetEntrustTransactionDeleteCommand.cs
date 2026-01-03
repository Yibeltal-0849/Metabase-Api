 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetEntrustTransaction.FixedAssetEntrustTransactionDelete.FixedAssetEntrustTransactionDeleteCommand
{

    // @author  Shimels Alem  Fixed_Asset_Entrust_TransactionDelete stored procedure.


    public class FixedAssetEntrustTransactionDeleteCommand : IRequest<IList<FixedAssetEntrustTransaction_Entrust_Trans_ID>>
    {
        public System.Guid Entrust_Trans_ID { get; set; }
    }
		
     
		
		 
	}
 
 