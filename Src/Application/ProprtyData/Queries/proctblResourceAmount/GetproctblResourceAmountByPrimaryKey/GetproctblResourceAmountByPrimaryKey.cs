using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceAmount.GetproctblResourceAmountLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceAmount.GetproctblResourceAmountByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceAmountLoadByPrimaryKey stored procedure.

    public class GetproctblResourceAmountByPrimaryKey : IRequest<GetproctblResourceAmountLoadAllListVm>
    {
        public long Resource_id { get; set; }
        public long ResourceVariable_id { get; set; }
        public System.DateTime Report_Period { get; set; }
    }
}
