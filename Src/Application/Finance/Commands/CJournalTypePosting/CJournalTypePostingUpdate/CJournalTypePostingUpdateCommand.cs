using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CJournalTypePosting.CJournalTypePostingUpdate.CJournalTypePostingUpdateCommand
{

	/// @author  Shimels Alem  C_Journal_Type_PostingUpdate stored procedure.


	public class CJournalTypePostingUpdateCommand : IRequest<IList<CJournalTypePosting_Type>>
   {
		public string Type { get; set; }
		public int? Steps { get; set; }
		public string Start_Debit_Accounts { get; set; }
		public string Start_Credit_Accounts { get; set; }
	}
		
		
		 
}

