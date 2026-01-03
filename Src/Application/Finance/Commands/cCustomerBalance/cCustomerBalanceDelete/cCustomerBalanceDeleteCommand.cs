 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cCustomerBalance.cCustomerBalanceDelete.cCustomerBalanceDeleteCommand
{

    // @author  Shimels Alem  c_Customer_BalanceDelete stored procedure.


    public class cCustomerBalanceDeleteCommand : IRequest<IList<CCustomerBalance_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
	}
 
 