using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Inventory.Quiries.Store.GetStoreLoadAll
{
    /// @author  Shimels Alem  proc_StoreLoadAll stored procedure.

    public class GetStoreLoadAllListVm
    {
        public IList<GetStoreLoadAllVm> Stores { get; set; }
    }
}
