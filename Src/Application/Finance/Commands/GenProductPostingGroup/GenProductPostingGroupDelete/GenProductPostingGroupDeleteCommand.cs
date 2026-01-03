 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GenProductPostingGroup.GenProductPostingGroupDelete.GenProductPostingGroupDeleteCommand
{

    // @author  Shimels Alem  Gen_Product_Posting_GroupDelete stored procedure.


    public class GenProductPostingGroupDeleteCommand : IRequest<IList<GenProductPostingGroup_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 