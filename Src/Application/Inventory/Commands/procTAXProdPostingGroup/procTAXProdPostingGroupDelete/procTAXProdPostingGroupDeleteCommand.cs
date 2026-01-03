 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.procTAXProdPostingGroup.procTAXProdPostingGroupDelete.procTAXProdPostingGroupDeleteCommand
{

    // @author  Shimels Alem  proc_TAX_Prod_Posting_GroupDelete stored procedure.


    public class procTAXProdPostingGroupDeleteCommand : IRequest<IList<TAX_Prod_Posting_Group_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
	}
 
 