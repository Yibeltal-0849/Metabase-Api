using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLCustomerLedgerEntries.GetprocLCustomerLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLCustomerLedgerEntries.GetprocLCustomerLedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem proc_L_Customer_Ledger_EntriesLoadByPrimaryKey stored procedure.

    public class GetprocLCustomerLedgerEntriesByPrimaryKey : IRequest<GetprocLCustomerLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public long Entry_No { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
