 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentContract.procRentContractDelete.procRentContractDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_ContractDelete stored procedure.


    public class procRentContractDeleteCommand : IRequest<IList<RentContract_Rent_Contract_ID>>
    {
        public System.Guid Rent_Contract_ID { get; set; }
    }
		
     
		
		 
}
 
 