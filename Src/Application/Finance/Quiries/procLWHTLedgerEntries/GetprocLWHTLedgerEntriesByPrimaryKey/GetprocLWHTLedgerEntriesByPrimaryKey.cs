using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLWHTLedgerEntries.GetprocLWHTLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLWHTLedgerEntries.GetprocLWHTLedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem proc_L_WHT_Ledger_EntriesLoadByPrimaryKey stored procedure.

    public class GetprocLWHTLedgerEntriesByPrimaryKey : IRequest<GetprocLWHTLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public System.Int64 Entry_No { get; set; }
        public System.DateTime Period { get; set; }
    }
}
