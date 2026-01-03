using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLInsCoverageLedgerEntries.GetprocLInsCoverageLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLInsCoverageLedgerEntries.GetprocLInsCoverageLedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem proc_L_Ins_Coverage_Ledger_EntriesLoadByPrimaryKey stored procedure.

    public class GetprocLInsCoverageLedgerEntriesByPrimaryKey : IRequest<GetprocLInsCoverageLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.Int64 EntryNo { get; set; }
        public System.DateTime Period { get; set; }
        public string PostingDate { get; set; }
    }
}
