 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDemand.proctblDemandDelete.proctblDemandDeleteCommand
{

    // @author  Shimels Alem  proc_tblDemandDelete stored procedure.


    public class proctblDemandDeleteCommand : IRequest<IList<tblDemand_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 