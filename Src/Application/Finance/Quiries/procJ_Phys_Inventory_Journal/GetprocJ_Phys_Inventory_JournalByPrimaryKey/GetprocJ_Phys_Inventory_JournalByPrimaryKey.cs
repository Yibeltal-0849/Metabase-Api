using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJ_Phys_Inventory_Journal.GetprocJ_Phys_Inventory_JournalLoadAll;

namespace Application.Finance.Quiries.procJ_Phys_Inventory_Journal.GetprocJ_Phys_Inventory_JournalByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetprocJ_Phys_Inventory_JournalByPrimaryKey : IRequest<GetprocJ_Phys_Inventory_JournalLoadAllListVm>
    {
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        
    }
}
