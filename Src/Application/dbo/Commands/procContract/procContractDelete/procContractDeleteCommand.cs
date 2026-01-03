 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procContract.procContractDelete.procContractDeleteCommand
{

    // @author  Shimels Alem  proc_ContractDelete stored procedure.


    public class procContractDeleteCommand : IRequest<IList<Contract_ContractNo>>
    {
        public string Contract_No { get; set; }
    }
		
     
		
		 
}
 
 