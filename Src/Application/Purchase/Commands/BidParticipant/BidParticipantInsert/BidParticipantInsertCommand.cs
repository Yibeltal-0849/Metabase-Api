


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidParticipant.BidParticipantInsert.BidParticipantInsertCommand
{

	/// @author  Shimels Alem  proc_Bid_ParticipantInsert stored procedure.


	public class BidParticipantInsertCommand : IRequest<IList<Bid_Participant_Participant_ID>>
    {
		public string Participant_ID { get; set; }
		public System.Guid? Bid_DetailID { get; set; }
		public string User_id { get; set; }
		public bool? Is_Customer { get; set; }
		public bool? Is_Vendor { get; set; }
		public string Customer_Id { get; set; }
		public string Vendor_ID { get; set; }
		public string Request_Number { get; set; }
		public bool? Is_Issued { get; set; }
	}
		
		
		 
	}
 
 