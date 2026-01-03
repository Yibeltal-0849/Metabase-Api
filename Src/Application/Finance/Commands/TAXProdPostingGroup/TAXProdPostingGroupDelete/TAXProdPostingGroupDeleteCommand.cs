 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Commands.TAXProdPostingGroup.TAXProdPostingGroupDelete.TAXProdPostingGroupDeleteCommand
{

    // @author  Shimels Alem  TAX_Prod_Posting_GroupDelete stored procedure.


    public class TAXProdPostingGroupDeleteCommand : IRequest<IList<TAX_Prod_Posting_Group_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 