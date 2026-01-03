 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LInsCoverageLedgerEntries.LInsCoverageLedgerEntriesDelete.LInsCoverageLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_Ins_Coverage_Ledger_EntriesDelete stored procedure.


    public class LInsCoverageLedgerEntriesDeleteCommand : IRequest<IList<L_Ins_Coverage_Ledger_Entries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public string PostingDate { get; set; }
        public System.Int64 EntryNo { get; set; }
    }
		
     
		
		 
}
 
 