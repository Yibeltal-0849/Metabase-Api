using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblLayers.GetproctblLayersLoadAll;

namespace Application.ProprtyData.Queries.proctblLayers.GetproctblLayersByPrimaryKey
{
    /// @author  Shimels Alem proc_tblLayersLoadByPrimaryKey stored procedure.

    public class GetproctblLayersByPrimaryKey : IRequest<GetproctblLayersLoadAllListVm>
    {
        public long id { get; set; }
    }
}
