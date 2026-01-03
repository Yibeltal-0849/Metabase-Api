using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLVATLedgerEntries.GetprocLVATLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLVATLedgerEntries.GetprocLVATLedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem  [proc_L_VAT_Ledger_ EntriesLoadByPrimaryKey] stored procedure.

    public class GetprocLVATLedgerEntriesByPrimaryKey : IRequest<GetprocLVATLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public long Entry_No { get; set; }
        public System.DateTime Period { get; set; }
    }
}
