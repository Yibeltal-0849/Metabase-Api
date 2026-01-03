 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumer.proctblConsumerDelete.proctblConsumerDeleteCommand
{

    // @author  Shimels Alem  proc_tblConsumerDelete stored procedure.


    public class proctblConsumerDeleteCommand : IRequest<IList<tblConsumer_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 