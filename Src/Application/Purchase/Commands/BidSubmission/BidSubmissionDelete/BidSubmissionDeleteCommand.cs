 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidSubmission.BidSubmissionDelete.BidSubmissionDeleteCommand
{

    // @author  Shimels Alem  proc_Bid_SubmtionDelete stored procedure.


    public class BidSubmissionDeleteCommand : IRequest<IList<BidSubmission_ParticipantID>>
    {
        public string Participant_ID { get; set; }
    }
		
     
		
		 
	}
 
 