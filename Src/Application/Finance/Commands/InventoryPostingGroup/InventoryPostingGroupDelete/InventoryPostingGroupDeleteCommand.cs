 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.InventoryPostingGroup.InventoryPostingGroupDelete.InventoryPostingGroupDeleteCommand
{

    // @author  Shimels Alem  Inventory_Posting_GroupDelete stored procedure.


    public class InventoryPostingGroupDeleteCommand : IRequest<IList<InventoryPostingGroup_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 