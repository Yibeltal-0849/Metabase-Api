using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidParticipant.BidParticipantUpdate.BidParticipantUpdateCommand
{

	/// @author  Shimels Alem  proc_Bid_ParticipantUpdate stored procedure.


	public class BidParticipantUpdateCommand : IRequest<IList<Bid_Participant_Participant_ID>>
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

