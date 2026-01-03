using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCJournalType.GetprocCJournalTypeLoadAll;

namespace Application.Finance.Quiries.procCJournalType.GetprocCJournalTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_C_Journal_TypeLoadByPrimaryKey stored procedure.

    public class GetprocCJournalTypeByPrimaryKey : IRequest<GetprocCJournalTypeLoadAllListVm>
    {
        public string Type { get; set; }
    }
}
