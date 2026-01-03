 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFacilityGISLayer.proctblFacilityGISLayerDelete.proctblFacilityGISLayerDeleteCommand
{

    // @author  Shimels Alem  proc_tblFacility_GISLayerDelete stored procedure.


    public class proctblFacilityGISLayerDeleteCommand : IRequest<IList<tblFacilityGISLayer_Facility_id>>
    {
        public long Facility_id { get; set; }
        public long FID { get; set; }
    }
		
     
		
		 
}
 
 