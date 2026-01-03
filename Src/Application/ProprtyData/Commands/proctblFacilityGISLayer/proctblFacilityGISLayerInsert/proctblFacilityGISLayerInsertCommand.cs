


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFacilityGISLayer.proctblFacilityGISLayerInsert.proctblFacilityGISLayerInsertCommand
{

    /// @author  Shimels Alem  proc_tblFacility_GISLayerInsert stored procedure.


    public class proctblFacilityGISLayerInsertCommand : IRequest<IList<tblFacilityGISLayer_Facility_id>>
    {
        public long Facility_id { get; set; }
        public long FID { get; set; }
    }
		
		
		 
}
 
 