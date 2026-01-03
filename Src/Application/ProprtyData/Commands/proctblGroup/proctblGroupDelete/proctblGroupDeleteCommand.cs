 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblGroup.proctblGroupDelete.proctblGroupDeleteCommand
{

    // @author  Shimels Alem  proc_tblGroupDelete stored procedure.


    public class proctblGroupDeleteCommand : IRequest<IList<tblGroup_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 