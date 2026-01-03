 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cInventoryBeginingBalances.cInventoryBeginingBalancesDelete.cInventoryBeginingBalancesDeleteCommand
{

    // @author  Shimels Alem  c_Inventory_Begining_BalancesDelete stored procedure.


    public class cInventoryBeginingBalancesDeleteCommand : IRequest<IList<CInventoryBeginingBalances_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
	}
 
 