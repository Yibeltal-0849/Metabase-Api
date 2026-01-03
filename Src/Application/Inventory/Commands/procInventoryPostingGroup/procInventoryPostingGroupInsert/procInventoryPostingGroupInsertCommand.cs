


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Inventory.Commands.procInventoryPostingGroup.procInventoryPostingGroupInsert.procInventoryPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_Inventory_Posting_GroupInsert stored procedure.


    public class procInventoryPostingGroupInsertCommand : IRequest<IList<InventoryPostingGroup_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
}
 
 