


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidSubmission.BidSubmissionInsert.BidSubmissionInsertCommand
{

	/// public string author  Shimels Alem  proc_Bid_SubmtionInsert stored procedure.


	public class BidSubmissionInsertCommand : IRequest<IList<BidSubmission_ParticipantID>>
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
 
 