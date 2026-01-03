using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceGISLayer.GetproctblResourceGISLayerLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceGISLayer.GetproctblResourceGISLayerByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResource_GISLayerLoadByPrimaryKey stored procedure.

    public class GetproctblResourceGISLayerByPrimaryKey : IRequest<GetproctblResourceGISLayerLoadAllListVm>
    {
        public long Resource_id { get; set; }
        public long FID { get; set; }
    }
}
