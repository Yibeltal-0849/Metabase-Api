 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Commands.TAXBusPostingGroup.TAXBusPostingGroupDelete.TAXBusPostingGroupDeleteCommand
{

    // @author  Shimels Alem  TAX_Bus_Posting_GroupDelete stored procedure.


    public class TAXBusPostingGroupDeleteCommand : IRequest<IList<TAX_Bus_Posting_Group_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 