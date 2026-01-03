using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupLoadAll;

namespace Application.Finance.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_TAX_Bus_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocTAXBusPostingGroupByPrimaryKey : IRequest<GetprocTAXBusPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
