 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblRegions.proctblRegionsDelete.proctblRegionsDeleteCommand
{

    // @author  Shimels Alem  proc_tblRegionsDelete stored procedure.


    public class proctblRegionsDeleteCommand : IRequest<IList<tblRegions_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 