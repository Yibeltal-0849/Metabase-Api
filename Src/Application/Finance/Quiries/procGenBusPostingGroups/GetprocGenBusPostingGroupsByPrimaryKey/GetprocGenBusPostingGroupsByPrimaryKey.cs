using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procGenBusPostingGroups.GetprocGenBusPostingGroupsLoadAll;

namespace Application.Finance.Quiries.procGenBusPostingGroups.GetprocGenBusPostingGroupsByPrimaryKey
{
    /// @author  Shimels Alem proc_Gen_Bus_Posting_GroupsLoadByPrimaryKey stored procedure.

    public class GetprocGenBusPostingGroupsByPrimaryKey : IRequest<GetprocGenBusPostingGroupsLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
