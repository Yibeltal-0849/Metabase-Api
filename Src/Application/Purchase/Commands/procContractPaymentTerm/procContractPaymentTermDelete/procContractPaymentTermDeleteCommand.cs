 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.procContractPaymentTerm.procContractPaymentTermDelete.procContractPaymentTermDeleteCommand
{

    // @author  Shimels Alem  proc_Contract_PaymentTermDelete stored procedure.


    public class procContractPaymentTermDeleteCommand : IRequest<IList<ContractPaymentTerm_PaymentTermID>>
    {
        public System.Guid Payment_TermID { get; set; }
    }
		
     
		
		 
}
 
 