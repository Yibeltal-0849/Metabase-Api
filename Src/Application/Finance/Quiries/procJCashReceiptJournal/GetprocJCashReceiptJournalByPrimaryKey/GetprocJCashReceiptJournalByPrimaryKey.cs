using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJCashReceiptJournal.GetprocJCashReceiptJournalLoadAll;

namespace Application.Finance.Quiries.procJCashReceiptJournal.GetprocJCashReceiptJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Cash_Receipt_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJCashReceiptJournalByPrimaryKey : IRequest<GetprocJCashReceiptJournalLoadAllListVm>
    {
        public string Account_No { get; set; }
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
