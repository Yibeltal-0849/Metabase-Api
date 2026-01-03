 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LBankAccountLedgerEntries.LBankAccountLedgerEntriesDelete.LBankAccountLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  L_Bank Account_Ledger_EntriesDelete stored procedure.


    public class LBankAccountLedgerEntriesDeleteCommand : IRequest<IList<LBankAccountLedgerEntries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public string Document_No { get; set; }
    }
		
     
		
		 
}
 
 