using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.Store.GetStoreLoadAll;

namespace Application.Inventory.Quiries.procTAXBusPostingGroup.Avalable_StoreList
{
    // @author  Shimels Alem proc_TAX_Bus_Posting_GroupLoadByPrimaryKey stored procedure.

    public class Avalable_StoreList : IRequest<GetStoreLoadAllListVm>
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public Guid Application_No { get; set; }
        public Guid UserID { get; set; }
    }
}
