 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.FixedAsset.Commands.procFixedAssetsPostingGroups.procFixedAssetsPostingGroupsDelete.procFixedAssetsPostingGroupsDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Assets_Posting_GroupsDelete stored procedure.


    public class procFixedAssetsPostingGroupsDeleteCommand : IRequest<IList<FixedAssetsPostingGroups_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
	}
 
 