 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.WithPostingGroup.WithPostingGroupDelete.WithPostingGroupDeleteCommand
{

    // @author  Shimels Alem  With_Posting_GroupDelete stored procedure.


    public class WithPostingGroupDeleteCommand : IRequest<IList<With_Posting_Group_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 