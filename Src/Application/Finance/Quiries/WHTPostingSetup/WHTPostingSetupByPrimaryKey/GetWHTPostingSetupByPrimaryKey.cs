using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procWithPostingGroup.WHTPostingSetupLoadAll;

namespace Application.Finance.Quiries.procWithPostingGroup.WHTPostingSetupByPrimaryKey
{
    /// @author  Shimels Alem proc_WHT_Posting_SetupLoadByPrimaryKey stored procedure.

    public class WHTPostingSetupByPrimaryKey : IRequest<WHTPostingSetupLoadAllListVm>
    {
        public string With_Posting_Group { get; set; }
        public string Bus_Posting_Group { get; set; }
        public string Prod_Posting_Group { get; set; }
    }
}
