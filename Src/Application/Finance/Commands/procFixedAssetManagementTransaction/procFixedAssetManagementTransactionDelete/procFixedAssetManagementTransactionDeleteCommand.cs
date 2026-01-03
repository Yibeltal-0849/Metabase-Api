 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetManagementTransaction.procFixedAssetManagementTransactionDelete.procFixedAssetManagementTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Asset_Management_TransactionDelete stored procedure.


    public class procFixedAssetManagementTransactionDeleteCommand : IRequest<IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>>
    {
        public System.Guid FixedAsset_Trans_ID { get; set; }
    }
		
     
		
		 
}
 
 