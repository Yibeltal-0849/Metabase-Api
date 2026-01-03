 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PTransactionPurchaseType.PTransactionPurchaseTypeDelete.PTransactionPurchaseTypeDeleteCommand
{

    // @author  Shimels Alem  [P_Transaction Purchase TypeDelete] stored procedure.


    public class PTransactionPurchaseTypeDeleteCommand : IRequest<IList<PTransactionPurchaseType_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 