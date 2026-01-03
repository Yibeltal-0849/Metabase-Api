using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procBankAccountPostingGroup.GetprocBankAccountPostingGroupLoadAll;

namespace Application.Finance.Quiries.procBankAccountPostingGroup.GetprocBankAccountPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_Bank_Account_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocBankAccountPostingGroupByPrimaryKey : IRequest<GetprocBankAccountPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
