 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procJBankReconTransaction.procJBankReconTransactionDelete.procJBankReconTransactionDeleteCommand
{
     
    // @author  Shimels Alem  proc_J_Bank_Recon_TransactionDelete stored procedure.
     
    public class procJBankReconTransactionDeleteCommand : IRequest<IList<JBankReconTransaction_TransID>>
    {
        public System.Guid Trans_ID { get; set; }
    }
		
     
		
		 
}
 
 