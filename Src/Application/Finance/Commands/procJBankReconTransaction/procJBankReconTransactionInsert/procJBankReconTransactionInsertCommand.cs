


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procJBankReconTransaction.procJBankReconTransactionInsert.procJBankReconTransactionInsertCommand
{ 
	 
	/// @author  Shimels Alem  proc_J_Bank_Recon_TransactionInsert stored procedure.
	 
     
        public class procJBankReconTransactionInsertCommand : IRequest<IList<JBankReconTransaction_TransID>>
    {
        public System.Guid Trans_ID { get; set; }
        public System.DateTime? Statement_Date { get; set; }
	    public string Statement_No { get; set; }
	    public decimal Balance_Last_Statement { get; set; }
        public decimal Statement_Ending_Balance { get; set; }
    }
		
		
		 
}
 
 