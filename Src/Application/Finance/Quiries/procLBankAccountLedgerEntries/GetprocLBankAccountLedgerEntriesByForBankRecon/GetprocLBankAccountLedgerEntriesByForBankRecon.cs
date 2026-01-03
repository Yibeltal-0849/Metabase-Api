using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesByForBankRecon
{
    /// @author  Shimels Alem [proc_L_Bank Account_Ledger_EntriesLoadByForBankRecon] stored procedure.

    public class GetprocLBankAccountLedgerEntriesByForBankRecon : IRequest<GetprocLBankAccountLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string BankAccount { get; set; }
   
    }
}
