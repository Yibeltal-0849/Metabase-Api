 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceBuyers.proctblResourceBuyersDelete.proctblResourceBuyersDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceBuyersDelete stored procedure.


    public class proctblResourceBuyersDeleteCommand : IRequest<IList<tblResourceBuyers_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 