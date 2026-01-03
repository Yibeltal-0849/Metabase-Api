using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem [proc_L_Bank Account_Ledger_EntriesLoadByPrimaryKey] stored procedure.

    public class GetprocLBankAccountLedgerEntriesByPrimaryKey : IRequest<GetprocLBankAccountLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public string Posting_Date { get; set; }
    }
}
