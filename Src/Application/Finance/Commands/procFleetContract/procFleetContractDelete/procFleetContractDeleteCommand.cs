 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFleetContract.procFleetContractDelete.procFleetContractDeleteCommand
{

    // @author  Shimels Alem  proc_Fleet_ContractDelete stored procedure.


    public class procFleetContractDeleteCommand : IRequest<IList<FleetContract_Contract_ID>>
    {

        public string Contract_ID { get; set; }
    }
		
     
		
		 
}
 
 