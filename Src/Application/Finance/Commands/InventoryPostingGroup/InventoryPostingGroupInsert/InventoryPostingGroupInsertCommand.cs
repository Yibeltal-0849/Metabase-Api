


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.InventoryPostingGroup.InventoryPostingGroupInsert.InventoryPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Inventory_Posting_GroupInsert stored procedure.


    public class InventoryPostingGroupInsertCommand : IRequest<IList<InventoryPostingGroup_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
}
 
 