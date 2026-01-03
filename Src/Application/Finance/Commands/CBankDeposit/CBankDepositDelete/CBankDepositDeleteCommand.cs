 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CBankDeposit.CBankDepositDelete.CBankDepositDeleteCommand
{

    // @author  Shimels Alem  C_Bank_DepositDelete stored procedure.


    public class CBankDepositDeleteCommand : IRequest<IList<CBankDeposit_Id>>
    {
        public System.Guid Id { get; set; }
    }
		
     
		
		 
	}
 
 