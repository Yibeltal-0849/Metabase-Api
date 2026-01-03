 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cJournalEntriesType.cJournalEntriesTypeDelete.cJournalEntriesTypeDeleteCommand
{

    // @author  Shimels Alem  c_Journal_Entries_TypeDelete stored procedure.


    public class cJournalEntriesTypeDeleteCommand : IRequest<IList<CJournalEntriesType_Type>>
    {
        public string Type { get; set; }
    }
		
     
		
		 
}
 
 