using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procSafetySecurity.GetprocSafetySecurityLoadAll;

namespace Application.Vehicle.Quiries.procSafetySecurity.GetprocSafetySecurityByPrimaryKey
{
    /// @author  Shimels Alem proc_Safety_SecurityLoadByPrimaryKey stored procedure.

    public class GetprocSafetySecurityByPrimaryKey : IRequest<GetprocSafetySecurityLoadAllListVm>
    {
        public System.Guid Safety_SecurityID { get; set; }
    }
}
