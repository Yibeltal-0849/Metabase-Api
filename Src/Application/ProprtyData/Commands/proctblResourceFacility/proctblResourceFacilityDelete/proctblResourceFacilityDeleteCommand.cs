 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceFacility.proctblResourceFacilityDelete.proctblResourceFacilityDeleteCommand
{

    // @author  Shimels Alem  proc_tblResource_FacilityDelete stored procedure.


    public class proctblResourceFacilityDeleteCommand : IRequest<IList<tblResourceFacility_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 