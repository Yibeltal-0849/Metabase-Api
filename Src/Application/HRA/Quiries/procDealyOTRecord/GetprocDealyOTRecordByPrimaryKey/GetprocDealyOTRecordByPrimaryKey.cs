using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procDealyOTRecord.GetprocDealyOTRecordLoadAll;

namespace Application.HRA.Quiries.procDealyOTRecord.GetprocDealyOTRecordByPrimaryKey
{
    /// @author  Shimels Alem proc_Dealy_OT_RecordLoadByPrimaryKey stored procedure.

    public class GetprocDealyOTRecordByPrimaryKey : IRequest<GetprocDealyOTRecordLoadAllListVm>
    {
        public System.Guid Dealy_OT_Record_ID { get; set; }
    }
}
