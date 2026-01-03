 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidOpening.BidOpeningDelete.BidOpeningDeleteCommand
{

    // @author  Shimels Alem  proc_Bid_OpeningDelete stored procedure.


    public class BidOpeningDeleteCommand : IRequest<IList<BidOpening_ParticipantID>>
    {

        public string Participant_ID { get; set; }
    }
		
     
		
		 
	}
 
 