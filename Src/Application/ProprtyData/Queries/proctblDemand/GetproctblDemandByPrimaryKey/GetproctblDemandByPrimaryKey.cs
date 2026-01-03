using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblDemand.GetproctblDemandLoadAll;

namespace Application.ProprtyData.Queries.proctblDemand.GetproctblDemandByPrimaryKey
{
    /// @author  Shimels Alem proc_tblDemandLoadByPrimaryKey stored procedure.

    public class GetproctblDemandByPrimaryKey : IRequest<GetproctblDemandLoadAllListVm>
    {
        public long id { get; set; }
    }
}
