using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.ProcInventoryPostingGroup.GetProcInventoryPostingGroupLoadAll;

namespace Application.Finance.Quiries.ProcInventoryPostingGroup.GetProcInventoryPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_Inventory_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetProcInventoryPostingGroupByPrimaryKey : IRequest<GetProcInventoryPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
