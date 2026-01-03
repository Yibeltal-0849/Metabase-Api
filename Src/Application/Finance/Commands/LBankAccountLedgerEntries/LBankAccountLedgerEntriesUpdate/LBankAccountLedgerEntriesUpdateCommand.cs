using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.LBankAccountLedgerEntries.LBankAccountLedgerEntriesUpdate.LBankAccountLedgerEntriesUpdateCommand
{

	/// @author  Shimels Alem  L_Bank Account_Ledger_EntriesUpdate stored procedure.


	public class LBankAccountLedgerEntriesUpdateCommand : IRequest<IList<LBankAccountLedgerEntries_Branch_ID>>
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

