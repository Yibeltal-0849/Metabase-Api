using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceStatus.GetproctblResourceStatusLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceStatus.GetproctblResourceStatusByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResource_StatusLoadByPrimaryKey stored procedure.

    public class GetproctblResourceStatusByPrimaryKey : IRequest<GetproctblResourceStatusLoadAllListVm>
    {
        public long id { get; set; }
    }
}
