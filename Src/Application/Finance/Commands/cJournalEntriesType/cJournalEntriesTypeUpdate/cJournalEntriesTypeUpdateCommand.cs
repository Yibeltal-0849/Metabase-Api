using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cJournalEntriesType.cJournalEntriesTypeUpdate.cJournalEntriesTypeUpdateCommand
{

	/// @author  Shimels Alem  c_Journal_Entries_TypeUpdate stored procedure.


	public class cJournalEntriesTypeUpdateCommand : IRequest<IList<CJournalEntriesType_Type>>
   {
		public string Type { get; set; }
		public string Form_Link { get; set; }
	}
		
		
		 
}

