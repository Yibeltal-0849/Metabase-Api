using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;

namespace Application.Inventory.Quiries.InventoryItems.GetprocInventoryItemsLoadByItem_Name
{
    /// @author  Shimels Alem proc_Inventory_ItemsLoadByPrimaryKey_For_Posting stored procedure.

    public class GetprocInventoryItemsLoadByItem_Name : IRequest<GetInventoryItemsLoadAllListVm>
    {
        public string Item_Name { get; set; }

    }
}
