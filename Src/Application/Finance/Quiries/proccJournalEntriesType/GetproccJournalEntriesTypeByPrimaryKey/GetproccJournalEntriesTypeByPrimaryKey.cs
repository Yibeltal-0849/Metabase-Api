using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccJournalEntriesType.GetproccJournalEntriesTypeLoadAll;

namespace Application.Finance.Quiries.proccJournalEntriesType.GetproccJournalEntriesTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Journal_Entries_TypeLoadByPrimaryKey stored procedure.

    public class GetproccJournalEntriesTypeByPrimaryKey : IRequest<GetproccJournalEntriesTypeLoadAllListVm>
    {
        public string Type { get; set; }
    }
}
