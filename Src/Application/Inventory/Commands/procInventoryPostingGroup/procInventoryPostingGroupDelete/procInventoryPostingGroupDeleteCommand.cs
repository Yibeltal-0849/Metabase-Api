 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Inventory.Commands.procInventoryPostingGroup.procInventoryPostingGroupDelete.procInventoryPostingGroupDeleteCommand
{

    // @author  Shimels Alem  proc_Inventory_Posting_GroupDelete stored procedure.


    public class procInventoryPostingGroupDeleteCommand : IRequest<IList<InventoryPostingGroup_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 