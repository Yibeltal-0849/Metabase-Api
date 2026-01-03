using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;

namespace Application.Inventory.Quiries.InventoryItems.GetprocInventoryItemsLoadByPrimaryKeyandItem_Name
{
    /// @author  Shimels Alem proc_Inventory_ItemsLoadByPrimaryKey_For_Posting stored procedure.

    public class GetprocInventoryItemsLoadByPrimaryKeyandItem_Name : IRequest<GetInventoryItemsLoadAllListVm>
    {
        public string Inv_ID { get; set; }
        public string Item_Name { get; set; }

    }
}
