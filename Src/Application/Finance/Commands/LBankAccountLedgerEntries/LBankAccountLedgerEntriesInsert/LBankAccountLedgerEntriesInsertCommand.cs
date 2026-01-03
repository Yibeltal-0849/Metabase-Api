


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LBankAccountLedgerEntries.LBankAccountLedgerEntriesInsert.LBankAccountLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_Bank Account_Ledger_EntriesInsert stored procedure.


    public class LBankAccountLedgerEntriesInsertCommand : IRequest<IList<LBankAccountLedgerEntries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public Nullable<System.DateTime> Period { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Bank_Account_No { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Nullable<bool> Open { get; set; }
        public Nullable<int> Entry_No { get; set; }
    }
		
		
		 
}
 
 