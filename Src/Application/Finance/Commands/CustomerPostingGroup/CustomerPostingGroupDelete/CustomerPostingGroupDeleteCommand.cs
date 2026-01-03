 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CustomerPostingGroup.CustomerPostingGroupDelete.CustomerPostingGroupDeleteCommand
{

    // @author  Shimels Alem  Customer_Posting_GroupDelete stored procedure.


    public class CustomerPostingGroupDeleteCommand : IRequest<IList<CustomerPostingGroup_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 