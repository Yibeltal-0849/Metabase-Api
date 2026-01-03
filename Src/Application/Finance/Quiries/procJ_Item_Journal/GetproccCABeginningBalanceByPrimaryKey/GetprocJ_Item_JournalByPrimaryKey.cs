using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJ_Item_Journal.GetprocJ_Item_JournalLoadAll;

namespace Application.Finance.Quiries.procJ_Item_Journal.GetprocJ_Item_JournalByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetprocJ_Item_JournalByPrimaryKey : IRequest<GetprocJ_Item_JournalLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        
    }
}
