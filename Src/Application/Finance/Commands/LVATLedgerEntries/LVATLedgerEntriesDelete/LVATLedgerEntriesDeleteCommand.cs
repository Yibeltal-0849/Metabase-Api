 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LVATLedgerEntries.LVATLedgerEntriesDelete.LVATLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_VAT_Ledger_ EntriesDelete stored procedure.


    public class LVATLedgerEntriesDeleteCommand : IRequest<IList<LVatLedgerEntries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public long Entry_No { get; set; }
        public string Document_No { get; set; }
    }
		
     
		
		 
}
 
 