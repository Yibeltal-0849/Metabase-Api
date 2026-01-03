 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblState.proctblStateDelete.proctblStateDeleteCommand
{

    // @author  Shimels Alem  proc_tblStateDelete stored procedure.


    public class proctblStateDeleteCommand : IRequest<IList<tblState_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 