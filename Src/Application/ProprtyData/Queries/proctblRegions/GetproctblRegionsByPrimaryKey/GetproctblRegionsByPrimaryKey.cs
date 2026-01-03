using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblRegions.GetproctblRegionsLoadAll;

namespace Application.ProprtyData.Queries.proctblRegions.GetproctblRegionsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblRegionsLoadByPrimaryKey stored procedure.

    public class GetproctblRegionsByPrimaryKey : IRequest<GetproctblRegionsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
