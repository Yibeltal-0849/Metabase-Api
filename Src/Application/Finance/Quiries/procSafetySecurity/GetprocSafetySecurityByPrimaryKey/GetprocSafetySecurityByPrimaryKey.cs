using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSafetySecurity.GetprocSafetySecurityLoadAll;

namespace Application.Finance.Quiries.procSafetySecurity.GetprocSafetySecurityByPrimaryKey
{
    /// @author  Shimels Alem [sp not found] stored procedure.

    public class GetprocSafetySecurityByPrimaryKey : IRequest<GetprocSafetySecurityLoadAllListVm>
    {
        public System.Guid Safety_SecurityID { get; set; }
    }
}
