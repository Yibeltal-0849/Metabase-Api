 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LVendorLedgerEntries.LVendorLedgerEntriesDelete.LVendorLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_Vendor_Ledger_EntriesDelete stored procedure.


    public class LVendorLedgerEntriesDeleteCommand : IRequest<IList<L_Vendor_Ledger_Entries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime PostingDate { get; set; }
        public System.Int64 EntryNo { get; set; }
    }
		
     
		
		 
}
 
 