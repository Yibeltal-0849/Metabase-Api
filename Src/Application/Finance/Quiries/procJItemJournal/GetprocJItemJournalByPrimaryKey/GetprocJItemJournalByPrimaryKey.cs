using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJItemJournal.GetprocJItemJournalLoadAll;

namespace Application.Finance.Quiries.procJItemJournal.GetprocJItemJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Item_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJItemJournalByPrimaryKey : IRequest<GetprocJItemJournalLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
