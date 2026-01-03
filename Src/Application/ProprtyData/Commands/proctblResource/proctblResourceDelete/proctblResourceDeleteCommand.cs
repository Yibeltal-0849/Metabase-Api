 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResource.proctblResourceDelete.proctblResourceDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceDelete stored procedure.


    public class proctblResourceDeleteCommand : IRequest<IList<tblResource_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 