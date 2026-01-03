using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidSubmission.BidSubmissionUpdate.BidSubmissionUpdateCommand
{

	/// @author  Shimels Alem  proc_Bid_SubmtionUpdate stored procedure.


	public class BidSubmissionUpdateCommand : IRequest<IList<BidSubmission_ParticipantID>>
	{
		public string Participant_ID { get; set; }
		public byte[] Techinical_Document_PDF_Format { get; set; }
		public byte[] Financial_Document_Password_Protected { get; set; }
		public string Token_to_Financial_Document { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public System.DateTime? Last_Updated_Date { get; set; }
		public bool? Submited { get; set; }
		public System.Guid? Submited_By_User { get; set; }
		public System.DateTime? Submited_Date { get; set; }
	}
		
		
		 
	}

