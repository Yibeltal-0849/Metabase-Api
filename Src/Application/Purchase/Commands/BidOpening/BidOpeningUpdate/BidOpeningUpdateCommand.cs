using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidOpening.BidOpeningUpdate.BidOpeningUpdateCommand
{

	/// @author  Shimels Alem  proc_Bid_OpeningUpdate stored procedure.


	public class BidOpeningUpdateCommand : IRequest<IList<BidOpening_ParticipantID>>
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

