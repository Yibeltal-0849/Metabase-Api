 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidResult.BidResultDelete.BidResultDeleteCommand
{

    // @author  Shimels Alem  Bid_ResultDelete stored procedure.


    public class BidResultDeleteCommand : IRequest<IList<BidResult_BidResult>>
    {
        public System.Guid Bid_Result { get; set; }
    }
		
		 
}
 
 