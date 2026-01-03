 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidAward.BidAwardDelete.BidAwardDeleteCommand
{

    // @author  Shimels Alem  proc_Bid_AwardDelete stored procedure.


    public class BidAwardDeleteCommand : IRequest<IList<Bid_Award_Bid_Award_ID>>
    {
        public System.Guid Bid_Award_ID { get; set; }
    }
		
     
		
		 
	}
 
 