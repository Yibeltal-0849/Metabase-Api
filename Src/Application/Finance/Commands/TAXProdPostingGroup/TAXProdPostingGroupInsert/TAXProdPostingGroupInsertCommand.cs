


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Commands.TAXProdPostingGroup.TAXProdPostingGroupInsert.TAXProdPostingGroupInsertCommand
{

    /// @author  Shimels Alem  TAX_Prod_Posting_GroupInsert stored procedure.


    public class TAXProdPostingGroupInsertCommand : IRequest<IList<TAX_Prod_Posting_Group_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
}
 
 