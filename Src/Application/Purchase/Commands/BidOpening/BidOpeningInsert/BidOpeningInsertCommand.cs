


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidOpening.BidOpeningInsert.BidOpeningInsertCommand
{

	/// @author  Shimels Alem  proc_Bid_OpeningInsert stored procedure.


	public class BidOpeningInsertCommand : IRequest<IList<BidOpening_ParticipantID>>
    {
		public string Participant_ID { get; set; }
		public System.DateTime? Techinical_Opening_Date { get; set; }
		public byte[] Techinical_Document_PDF_Format { get; set; }
		public System.DateTime? Financial_Opening_Date { get; set; }
		public byte[] Financial_Document_Password_Protected { get; set; }
		public string Remark { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public System.DateTime? Last_Updated { get; set; }
	}
		
		
		 
}
 
 