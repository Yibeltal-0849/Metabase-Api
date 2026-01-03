 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LWHTLedgerEntries.LWHTLedgerEntriesDelete.LWHTLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_WHT_Ledger_EntriesDelete stored procedure.


    public class LWHTLedgerEntriesDeleteCommand : IRequest<IList<L_WHT_Ledger_Entries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.Int64 Entry_No { get; set; }
        public string Document_No { get; set; }
    }
		
     
		
}
 
 