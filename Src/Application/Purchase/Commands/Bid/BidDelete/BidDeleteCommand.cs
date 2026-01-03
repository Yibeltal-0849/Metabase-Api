 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.Bid.BidDelete.BidDeleteCommand
{

    // @author  Shimels Alem  proc_BidDelete stored procedure.


    public class BidDeleteCommand : IRequest<IList<_Bid_Bid_ID>>
    {
        public System.Guid Bid_ID { get; set; }
    }
		
     
		
		 
	}
 
 