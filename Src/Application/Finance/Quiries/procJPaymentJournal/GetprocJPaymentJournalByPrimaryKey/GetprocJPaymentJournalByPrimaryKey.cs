using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJPaymentJournal.GetprocJPaymentJournalLoadAll;

namespace Application.Finance.Quiries.procJPaymentJournal.GetprocJPaymentJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Payment_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJPaymentJournalByPrimaryKey : IRequest<GetprocJPaymentJournalLoadAllListVm>
    {
        public string Account_No { get; set; }
        public System.Guid Brnach_ID { get; set; }
        public string Document_No { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
