 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblZones.proctblZonesDelete.proctblZonesDeleteCommand
{

    // @author  Shimels Alem  proc_tblZonesDelete stored procedure.


    public class proctblZonesDeleteCommand : IRequest<IList<tblZones_id>>
    {
        public int id { get; set; }
    }
		
     
		
		 
}
 
 