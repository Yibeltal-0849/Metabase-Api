 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LJobLedgerEntries.LJobLedgerEntriesDelete.LJobLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_Job_Ledger_EntriesDelete stored procedure.


    public class LJobLedgerEntriesDeleteCommand : IRequest<IList<LJobLedgerEntries_PostingDate>>
    {
        public string PostingDate { get; set; }
    }
		
     
		
		 
}
 
 