using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupLoadAll;

namespace Application.Inventory.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupByPrimaryKey
{
    // @author  Shimels Alem proc_TAX_Bus_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocTAXBusPostingGroupByPrimaryKey : IRequest<GetprocTAXBusPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
