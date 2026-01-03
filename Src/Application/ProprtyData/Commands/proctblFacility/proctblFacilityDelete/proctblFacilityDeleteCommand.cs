 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFacility.proctblFacilityDelete.proctblFacilityDeleteCommand
{

    // @author  Shimels Alem  proc_tblFacilityDelete stored procedure.


    public class proctblFacilityDeleteCommand : IRequest<IList<tblFacility_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 