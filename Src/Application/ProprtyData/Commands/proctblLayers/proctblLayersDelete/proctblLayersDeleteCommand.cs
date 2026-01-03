 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblLayers.proctblLayersDelete.proctblLayersDeleteCommand
{

    // @author  Shimels Alem  proc_tblLayersDelete stored procedure.


    public class proctblLayersDeleteCommand : IRequest<IList<tblLayers_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 