 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LFALedgerEntries.LFALedgerEntriesDelete.LFALedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_FA_Ledger_EntriesDelete stored procedure.


    public class LFALedgerEntriesDeleteCommand : IRequest<IList<L_FA_Ledger_Entries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public System.Int64 Entry_No { get; set; }
    }
		
     
		
		 
}
 
 