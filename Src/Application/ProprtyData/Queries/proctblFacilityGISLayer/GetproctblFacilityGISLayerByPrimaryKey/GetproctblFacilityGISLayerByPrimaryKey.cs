using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblFacilityGISLayer.GetproctblFacilityGISLayerLoadAll;

namespace Application.ProprtyData.Queries.proctblFacilityGISLayer.GetproctblFacilityGISLayerByPrimaryKey
{
    /// @author  Shimels Alem proc_tblFacility_GISLayerLoadByPrimaryKey stored procedure.

    public class GetproctblFacilityGISLayerByPrimaryKey : IRequest<GetproctblFacilityGISLayerLoadAllListVm>
    {
        public long Facility_id { get; set; }
        public long FID { get; set; }
    }
}
