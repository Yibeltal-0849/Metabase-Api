using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblConsumed.GetproctblConsumedLoadAll;

namespace Application.ProprtyData.Queries.proctblConsumed.GetproctblConsumedByPrimaryKey
{
    /// @author  Shimels Alem proc_tblConsumedLoadByPrimaryKey stored procedure.

    public class GetproctblConsumedByPrimaryKey : IRequest<GetproctblConsumedLoadAllListVm>
    {
        public long id { get; set; }
    }
}
