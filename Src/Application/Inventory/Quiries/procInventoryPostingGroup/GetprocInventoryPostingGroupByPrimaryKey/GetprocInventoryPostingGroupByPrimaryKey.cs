using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procInventoryPostingGroup.GetprocInventoryPostingGroupLoadAll;

namespace Application.Inventory.Quiries.procInventoryPostingGroup.GetprocInventoryPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_Inventory_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocInventoryPostingGroupByPrimaryKey : IRequest<GetprocInventoryPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
