using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJJOBJournal.GetprocJJOBJournalLoadAll;

namespace Application.Finance.Quiries.procJJOBJournal.GetprocJJOBJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_JOB_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJJOBJournalByPrimaryKey : IRequest<GetprocJJOBJournalLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
