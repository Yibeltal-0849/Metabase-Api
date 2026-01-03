using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procBankAccountPostingGroup.GetprocBankAccountPostingGroupLoadAll;

namespace Application.Finance.Quiries.procBankAccountPostingGroup.GetprocBankAccountPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_Bank_Account_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocBankAccountPostingGroupBybranch : IRequest<GAvalable_bankListVm>
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public Guid Application_No { get; set; }
        public Guid UserID { get; set; }
    }
}
