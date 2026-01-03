using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccJ_Purchase_Journal.GetproccJ_Purchase_JournalLoadAll;

namespace Application.Finance.Quiries.proccJ_Purchase_Journal.GetproccJ_Purchase_JournalByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetproccJ_Purchase_JournalByPrimaryKey : IRequest<GetproccJ_Purchase_JournalLoadAllListVm>
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
    }
}
