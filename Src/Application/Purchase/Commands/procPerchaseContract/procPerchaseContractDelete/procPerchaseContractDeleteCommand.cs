 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.procPerchaseContract.procPerchaseContractDelete.procPerchaseContractDeleteCommand
{

    // @author  Shimels Alem  proc_Perchase_ContractDelete stored procedure.


    public class procPerchaseContractDeleteCommand : IRequest<IList<Perchase_Contract_Purchase_Contract>>
    {
        public string Purchase_Contract { get; set; }
    }
		
     
		
		 
}
 
 