 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceGISLayer.proctblResourceGISLayerDelete.proctblResourceGISLayerDeleteCommand
{

    // @author  Shimels Alem  proc_tblResource_GISLayerDelete stored procedure.


    public class proctblResourceGISLayerDeleteCommand : IRequest<IList<tblResourceGISLayer_Resource_id>>
    {
        public long Resource_id { get; set; }
        public long FID { get; set; }
    }
		
     
		
		 
}
 
 