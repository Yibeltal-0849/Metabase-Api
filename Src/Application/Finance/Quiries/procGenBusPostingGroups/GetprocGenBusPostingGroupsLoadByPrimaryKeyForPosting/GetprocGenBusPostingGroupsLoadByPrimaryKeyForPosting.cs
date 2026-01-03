using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procGenBusPostingGroups.GetprocGenBusPostingGroupsLoadAll;

namespace Application.Finance.Quiries.procGenBusPostingGroups.GetprocGenBusPostingGroupsLoadByPrimaryKeyForPosting
{
    /// @author  Shimels Alem proc_Gen_Bus_Posting_GroupsLoadByPrimaryKeyForPosting stored procedure.

    public class GetprocGenBusPostingGroupsLoadByPrimaryKeyForPosting : IRequest<GetprocGenBusPostingGroupsLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
