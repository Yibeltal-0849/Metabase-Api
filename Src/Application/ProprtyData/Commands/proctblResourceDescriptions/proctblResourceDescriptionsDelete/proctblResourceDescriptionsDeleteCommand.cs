 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceDescriptions.proctblResourceDescriptionsDelete.proctblResourceDescriptionsDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceDescriptionsDelete stored procedure.


    public class proctblResourceDescriptionsDeleteCommand : IRequest<IList<tblResourceDescriptions_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 