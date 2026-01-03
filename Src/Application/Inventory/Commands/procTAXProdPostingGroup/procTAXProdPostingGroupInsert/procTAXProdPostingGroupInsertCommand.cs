


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.procTAXProdPostingGroup.procTAXProdPostingGroupInsert.procTAXProdPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_TAX_Prod_Posting_GroupInsert stored procedure.


    public class procTAXProdPostingGroupInsertCommand : IRequest<IList<TAX_Prod_Posting_Group_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
	}
 
 