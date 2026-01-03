using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procWorkInfo.GetprocWorkInfoLoadAll;

namespace Application.HRA.Quiries.procWorkInfo.GetprocWorkInfoByPrimaryKey
{
    /// @author  Shimels Alem proc_Work_InfoLoadByPrimaryKey stored procedure.

    public class GetprocWorkInfoByPrimaryKey : IRequest<GetprocWorkInfoLoadAllListVm>
    {
        public System.Guid WorkInfo_ID { get; set; }
    }
}
