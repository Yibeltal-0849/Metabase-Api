 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblWindPotential.proctblWindPotentialDelete.proctblWindPotentialDeleteCommand
{

    // @author  Shimels Alem  proc_tblWindPotentialDelete stored procedure.


    public class proctblWindPotentialDeleteCommand : IRequest<IList<tblWindPotential_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 