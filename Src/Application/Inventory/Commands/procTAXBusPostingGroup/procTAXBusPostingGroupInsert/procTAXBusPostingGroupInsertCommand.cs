


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.procTAXBusPostingGroup.procTAXBusPostingGroupInsert.procTAXBusPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_TAX_Bus_Posting_GroupInsert stored procedure.


    public class procTAXBusPostingGroupInsertCommand : IRequest<IList<TAX_Bus_Posting_Group_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
	}
 
 