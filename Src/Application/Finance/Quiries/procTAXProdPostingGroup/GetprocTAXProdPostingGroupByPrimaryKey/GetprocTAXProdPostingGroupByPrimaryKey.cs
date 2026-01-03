using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupLoadAll;

namespace Application.Finance.Quiries.procTAXProdPostingGroup.GetprocTAXProdPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_TAX_Prod_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocTAXProdPostingGroupByPrimaryKey : IRequest<GetprocTAXProdPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
