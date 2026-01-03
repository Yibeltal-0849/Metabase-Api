 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceStatus.proctblResourceStatusDelete.proctblResourceStatusDeleteCommand
{

    // @author  Shimels Alem  proc_tblResource_StatusDelete stored procedure.


    public class proctblResourceStatusDeleteCommand : IRequest<IList<tblResourceStatus_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 