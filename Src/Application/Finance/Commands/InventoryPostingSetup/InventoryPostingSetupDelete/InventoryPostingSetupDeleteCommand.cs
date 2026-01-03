 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.InventoryPostingSetup.InventoryPostingSetupDelete.InventoryPostingSetupDeleteCommand
{

    // @author  Shimels Alem  Inventory_Posting_SetupDelete stored procedure.


    public class InventoryPostingSetupDeleteCommand : IRequest<IList<InventoryPostingSetup_Store_Code>>
    {
        public string Store_Code { get; set; }
    }
		
     
		
		 
}
 
 