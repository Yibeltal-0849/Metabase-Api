 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.procTAXBusPostingGroup.procTAXBusPostingGroupDelete.procTAXBusPostingGroupDeleteCommand
{

    // @author  Shimels Alem  proc_TAX_Bus_Posting_GroupDelete stored procedure.


    public class procTAXBusPostingGroupDeleteCommand : IRequest<IList<TAX_Bus_Posting_Group_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
	}
 
 