 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidParticipant.BidParticipantDelete.BidParticipantDeleteCommand
{

    // @author  Shimels Alem  proc_Bid_ParticipantDelete stored procedure.


    public class BidParticipantDeleteCommand : IRequest<IList<Bid_Participant_Participant_ID>>
    {
        public string Participant_ID { get; set; }
    }
		
     
		
		 
	}
 
 