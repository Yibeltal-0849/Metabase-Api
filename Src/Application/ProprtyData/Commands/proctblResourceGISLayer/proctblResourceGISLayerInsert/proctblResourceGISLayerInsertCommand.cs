


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceGISLayer.proctblResourceGISLayerInsert.proctblResourceGISLayerInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_GISLayerInsert stored procedure.


    public class proctblResourceGISLayerInsertCommand : IRequest<IList<tblResourceGISLayer_Resource_id>>
    {
        public long Resource_id { get; set; }
        public long FID { get; set; }
        public long? LayerId { get; set; }
        public long? Chain { get; set; }
        public long? Energy { get; set; }
    }
		
		
		 
}
 
 