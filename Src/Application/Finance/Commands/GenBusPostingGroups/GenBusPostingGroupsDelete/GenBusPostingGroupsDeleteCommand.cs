 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GenBusPostingGroups.GenBusPostingGroupsDelete.GenBusPostingGroupsDeleteCommand
{

    // @author  Shimels Alem  Gen_Bus_Posting_GroupsDelete stored procedure.


    public class GenBusPostingGroupsDeleteCommand : IRequest<IList<GenBusPostingGroups_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 