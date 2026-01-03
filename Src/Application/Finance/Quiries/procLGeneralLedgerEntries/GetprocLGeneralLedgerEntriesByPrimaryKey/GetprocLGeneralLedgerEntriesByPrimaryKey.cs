using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLGeneralLedgerEntries.GetprocLGeneralLedgerEntriesLoadAll;

namespace Application.Finance.Quiries.procLGeneralLedgerEntries.GetprocLGeneralLedgerEntriesByPrimaryKey
{
    /// @author  Shimels Alem proc_LGeneralLedgerEntriesLoadByPrimaryKey stored procedure.

    public class GetprocLGeneralLedgerEntriesByPrimaryKey : IRequest<GetprocLGeneralLedgerEntriesLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
    }
}
