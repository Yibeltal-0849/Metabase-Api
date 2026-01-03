 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumed.proctblConsumedDelete.proctblConsumedDeleteCommand
{

    // @author  Shimels Alem  proc_tblConsumedDelete stored procedure.


    public class proctblConsumedDeleteCommand : IRequest<IList<tblConsumed_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 