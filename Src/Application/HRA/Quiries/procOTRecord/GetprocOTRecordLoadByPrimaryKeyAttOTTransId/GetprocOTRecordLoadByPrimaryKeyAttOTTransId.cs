using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procOTRecord.GetprocOTRecordLoadAll;

namespace Application.HRA.Quiries.procOTRecord.GetprocOTRecordLoadByPrimaryKeyAttOTTransId
{
    /// @author  Shimels Alem proc_OT_RecordLoadByPrimaryKey_Att_OT_Trans_Id stored procedure.

    public class GetprocOTRecordLoadByPrimaryKeyAttOTTransId : IRequest<GetprocOTRecordLoadAllListVm>
    {
        public Guid Att_OT_Trans_Id { get; set; }
    }
}
