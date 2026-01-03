using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJInsuranceJournal.GetprocJInsuranceJournalLoadAll;

namespace Application.Finance.Quiries.procJInsuranceJournal.GetprocJInsuranceJournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Insurance_JournalLoadByPrimaryKey stored procedure.

    public class GetprocJInsuranceJournalByPrimaryKey : IRequest<GetprocJInsuranceJournalLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public string Document_No { get; set; }
        public string Posting_Date { get; set; }
    }
}
