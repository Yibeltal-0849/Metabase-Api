using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCustomerPostingGroup.GetprocCustomerPostingGroupLoadAll;

namespace Application.Finance.Quiries.procCustomerPostingGroup.GetprocCustomerPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_Customer_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocCustomerPostingGroupByPrimaryKey : IRequest<GetprocCustomerPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
