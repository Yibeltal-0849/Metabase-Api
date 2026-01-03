using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblZones.GetproctblZonesLoadAll;

namespace Application.ProprtyData.Queries.proctblZones.GetproctblZonesByPrimaryKey
{
    /// @author  Shimels Alem proc_tblZonesLoadByPrimaryKey stored procedure.

    public class GetproctblZonesByPrimaryKey : IRequest<GetproctblZonesLoadAllListVm>
    {
        public int id { get; set; }
    }
}
