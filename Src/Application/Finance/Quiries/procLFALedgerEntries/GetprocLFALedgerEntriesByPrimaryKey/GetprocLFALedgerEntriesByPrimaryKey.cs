using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLFALedgerEntries.GetprocLFALedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLFALedgerEntries.GetprocLFALedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem proc_L_FA_Ledger_EntriesLoadByPrimaryKey stored procedure.

    public class GetprocLFALedgerEntriesByPrimaryKey : IRequest<GetprocLFALedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.Int64 Entry_No { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public System.DateTime Period { get; set; }
    }
}
