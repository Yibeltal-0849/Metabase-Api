using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupLoadAll;

namespace Application.Inventory.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_TAX_Prod_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocTAXProdPostingGroupByPrimaryKey : IRequest<GetprocTAXProdPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
