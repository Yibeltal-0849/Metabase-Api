 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblSubSectors.proctblSubSectorsDelete.proctblSubSectorsDeleteCommand
{

    // @author  Shimels Alem  proc_tblSubSectorsDelete stored procedure.


    public class proctblSubSectorsDeleteCommand : IRequest<IList<tblSubSectors_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 