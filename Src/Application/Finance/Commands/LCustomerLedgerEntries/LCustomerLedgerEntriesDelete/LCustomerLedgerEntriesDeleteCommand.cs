 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LCustomerLedgerEntries.LCustomerLedgerEntriesDelete.LCustomerLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_Customer_Ledger_EntriesDelete stored procedure.


    public class LCustomerLedgerEntriesDeleteCommand : IRequest<IList<LCustomerLedgerEntries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public long Entry_No { get; set; }
    }
		
     
		
		 
}
 
 