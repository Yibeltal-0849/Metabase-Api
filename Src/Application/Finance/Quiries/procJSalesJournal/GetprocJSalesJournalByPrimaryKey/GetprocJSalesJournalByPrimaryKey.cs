using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJSalesJournal.GetprocJSalesJournalLoadAll;

namespace Application.Finance.Quiries.procJSalesJournal.GetprocJSalesJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Sales_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJSalesJournalByPrimaryKey : IRequest<GetprocJSalesJournalLoadAllListVm>
    {
        public string Account_No { get; set; }
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
