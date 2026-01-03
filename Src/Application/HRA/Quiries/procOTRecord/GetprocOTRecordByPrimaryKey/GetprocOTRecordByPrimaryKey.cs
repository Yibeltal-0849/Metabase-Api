using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procOTRecord.GetprocOTRecordLoadAll;

namespace Application.HRA.Quiries.procOTRecord.GetprocOTRecordByPrimaryKey
{
    /// @author  Shimels Alem proc_OT_RecordLoadByPrimaryKey stored procedure.

    public class GetprocOTRecordByPrimaryKey : IRequest<GetprocOTRecordLoadAllListVm>
    {
        public System.Guid OT_ID { get; set; }
    }
}
