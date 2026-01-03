using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procWithPostingGroup.GetprocWithPostingGroupLoadAll;

namespace Application.Finance.Quiries.procWithPostingGroup.GetprocWithPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_With_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocWithPostingGroupByPrimaryKey : IRequest<GetprocWithPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
