using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJ_Fixed_Asset_Journal.GetprocJ_Fixed_Asset_JournalLoadAll;

namespace Application.Finance.Quiries.procJ_Fixed_Asset_Journal.GetprocJ_Fixed_Asset_JournalByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetprocJ_Fixed_Asset_JournalByPrimaryKey : IRequest<GetprocJ_Fixed_Asset_JournalLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string FA_No { get; set; }
    }
}