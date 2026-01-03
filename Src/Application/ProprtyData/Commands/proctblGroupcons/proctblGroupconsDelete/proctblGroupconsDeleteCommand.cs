 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblGroupcons.proctblGroupconsDelete.proctblGroupconsDeleteCommand
{

    // @author  Shimels Alem  proc_tblGroup_consDelete stored procedure.


    public class proctblGroupconsDeleteCommand : IRequest<IList<tblGroupcons_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 