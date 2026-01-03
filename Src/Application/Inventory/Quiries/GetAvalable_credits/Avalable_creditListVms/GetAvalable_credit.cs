using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.GetAvalable_credits.Avalable_creditby;

namespace Application.Finance.Quiries.Avalable_credits.Avalable_creditListVms
{
    /// @author  Shimels Alem proc_Bank_Account_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetAvalable_credit : IRequest<Avalable_creditListVm>
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public Guid Application_No { get; set; }
        public Guid UserID { get; set; }
        
    }
}
