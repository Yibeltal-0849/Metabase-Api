 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumption.proctblConsumptionDelete.proctblConsumptionDeleteCommand
{

    // @author  Shimels Alem  proc_tblConsumptionDelete stored procedure.


    public class proctblConsumptionDeleteCommand : IRequest<IList<tblConsumption_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 