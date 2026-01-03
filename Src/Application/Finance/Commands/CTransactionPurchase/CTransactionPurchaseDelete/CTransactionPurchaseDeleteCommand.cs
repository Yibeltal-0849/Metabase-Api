 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CTransactionPurchase.CTransactionPurchaseDelete.CTransactionPurchaseDeleteCommand
{

    // @author  Shimels Alem  proc_CTransaction_PurchaseDelete stored procedure.


    public class CTransactionPurchaseDeleteCommand : IRequest<IList<CTransactionPurchase_No>>
    {
        public string No { get; set; }
    }
		
     
		
		 
}
 
 