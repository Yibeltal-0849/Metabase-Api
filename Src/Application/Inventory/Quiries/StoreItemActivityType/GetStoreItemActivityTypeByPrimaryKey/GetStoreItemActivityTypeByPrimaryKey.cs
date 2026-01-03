using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeLoadAll;

namespace Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Store_Item_Activity_TypeLoadByPrimaryKey stored procedure.

    public class GetStoreItemActivityTypeByPrimaryKey : IRequest<GetStoreItemActivityTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
