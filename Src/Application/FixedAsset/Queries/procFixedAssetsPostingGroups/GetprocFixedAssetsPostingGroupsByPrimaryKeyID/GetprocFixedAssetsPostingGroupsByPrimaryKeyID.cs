using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsByPrimaryKeyID
{
    /// @author  Shimels Alem proc_Fixed_Assets_Posting_GroupsLoadByPrimaryKeyID stored procedure.

    public class GetprocFixedAssetsPostingGroupsByPrimaryKeyID : IRequest<GetprocFixedAssetsPostingGroupsLoadAllListVm>
    {
		public string Code { get; set; }
	}
}
