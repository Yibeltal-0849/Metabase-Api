using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJGeneraljournal.GetprocJGeneraljournalLoadAll;

namespace Application.Finance.Quiries.procJGeneraljournal.GetprocJGeneraljournalByPrimaryKey
{
    /// @author  Shimels Alem proc_J_General_journalLoadByPrimaryKey stored procedure.

    public class GetprocJGeneraljournalByPrimaryKey : IRequest<GetprocJGeneraljournalLoadAllListVm>
    {
        public string Account_Id { get; set; }
        public System.Guid Brnach_ID { get; set; }
        public string Document_NO { get; set; }
        public System.DateTime Posting_Date { get; set; }
    }
}
