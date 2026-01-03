 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.FixedAssetsPostingGroups.FixedAssetsPostingGroupsDelete.FixedAssetsPostingGroupsDeleteCommand
{

    // @author  Shimels Alem  [Fixed_Assets_Posting_GroupsDelete] stored procedure.


    public class FixedAssetsPostingGroupsDeleteCommand : IRequest<IList<FixedAssetsPostingGroups_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 