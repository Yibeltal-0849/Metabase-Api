 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetManagementTransaction.FixedAssetManagementTransactionDelete.FixedAssetManagementTransactionDeleteCommand
{

    // @author  Shimels Alem  Fixed_Asset_Management_TransactionDelete stored procedure.


    public class FixedAssetManagementTransactionDeleteCommand : IRequest<IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>>
    {
        public System.Guid FixedAsset_Trans_ID { get; set; }
    }
		
     
		
		 
	}
 
 