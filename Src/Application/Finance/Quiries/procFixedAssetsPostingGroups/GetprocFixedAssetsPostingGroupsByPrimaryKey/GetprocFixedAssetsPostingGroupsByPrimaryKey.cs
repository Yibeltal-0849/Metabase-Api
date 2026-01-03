using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsLoadAll;

namespace Application.Finance.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Assets_Posting_GroupsLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetsPostingGroupsByPrimaryKey : IRequest<GetprocFixedAssetsPostingGroupsLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
