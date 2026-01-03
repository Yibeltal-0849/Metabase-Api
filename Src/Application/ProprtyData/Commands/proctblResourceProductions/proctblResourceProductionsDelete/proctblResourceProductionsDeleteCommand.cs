 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceProductions.proctblResourceProductionsDelete.proctblResourceProductionsDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceProductionsDelete stored procedure.


    public class proctblResourceProductionsDeleteCommand : IRequest<IList<tblResourceProductions_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 