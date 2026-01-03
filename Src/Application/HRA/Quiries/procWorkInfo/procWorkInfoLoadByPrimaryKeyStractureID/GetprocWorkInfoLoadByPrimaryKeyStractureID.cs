using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procWorkInfo.GetprocWorkInfoLoadAll;

namespace Application.HRA.Quiries.procWorkInfo.procWorkInfoLoadByPrimaryKeyStractureID
{
    /// @author  Shimels Alem procWorkInfoLoadByPrimaryKeyStractureID stored procedure.

    public class procWorkInfoLoadByPrimaryKeyStractureID : IRequest<GetprocWorkInfoLoadAllListVm>
    {
        public System.Guid Structure_ID { get; set; }
    }
}
