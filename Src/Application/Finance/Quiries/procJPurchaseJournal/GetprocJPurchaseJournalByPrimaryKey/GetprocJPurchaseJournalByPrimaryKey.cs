using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJPurchaseJournal.GetprocJPurchaseJournalLoadAll;

namespace Application.Finance.Quiries.procJPurchaseJournal.GetprocJPurchaseJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Purchase_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJPurchaseJournalByPrimaryKey : IRequest<GetprocJPurchaseJournalLoadAllListVm>
    {
        public System.Guid Org_ID { get; set; }
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
    }
}
