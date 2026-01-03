 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumptionDetail.proctblConsumptionDetailDelete.proctblConsumptionDetailDeleteCommand
{

    // @author  Shimels Alem  proc_tblConsumption_DetailDelete stored procedure.


    public class proctblConsumptionDetailDeleteCommand : IRequest<IList<tblConsumptionDetail_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 