using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeLoadAll
{
    /// @author  Shimels Alem  proc_Store_Item_Activity_TypeLoadAll stored procedure.

    public class GetStoreItemActivityTypeLoadAllListVm
    {
        public IList<GetStoreItemActivityTypeLoadAllVm> StoreItemActivityTypes { get; set; }
    }
}
