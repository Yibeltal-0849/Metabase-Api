


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cJournalEntriesType.cJournalEntriesTypeInsert.cJournalEntriesTypeInsertCommand
{

    /// @author  Shimels Alem  c_Journal_Entries_TypeInsert stored procedure.


    public class cJournalEntriesTypeInsertCommand : IRequest<IList<CJournalEntriesType_Type>>
    {
        public string Type { get; set; }
        public string Form_Link { get; set; }
    }
		
		
		 
}
 
 