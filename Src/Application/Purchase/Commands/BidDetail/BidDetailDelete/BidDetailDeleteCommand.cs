 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidDetail.BidDetailDelete.BidDetailDeleteCommand
{

    // @author  Shimels Alem  proc_Bid_DetailDelete stored procedure.


    public class BidDetailDeleteCommand : IRequest<IList<Bid_Detail_Bid_DetailID>>
    {
        public System.Guid Bid_DetailID { get; set; }
    }
		
     
		
		 
	}
 
 