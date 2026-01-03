 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cGeneraljournalEntries.cGeneraljournalEntriesDelete.cGeneraljournalEntriesDeleteCommand
{

    // @author  Shimels Alem  c_General_journal_Entries Delete stored procedure.


    public class cGeneraljournalEntriesDeleteCommand : IRequest<IList<CGeneralJournalEntries_Brnach_ID>>
    {
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime DateDoc { get; set; }
        public string Account_No { get; set; }
    }
		
     
		
		 
	}
 
 