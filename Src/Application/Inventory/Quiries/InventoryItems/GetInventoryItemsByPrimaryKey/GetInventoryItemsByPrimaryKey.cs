using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;

namespace Application.Inventory.Quiries.InventoryItems.GetInventoryItemsByPrimaryKey
{
    /// @author  Shimels Alem proc_Inventory_ItemsLoadByPrimaryKey stored procedure.

    public class GetInventoryItemsByPrimaryKey : IRequest<GetInventoryItemsLoadAllListVm>
    {
        public string Inv_ID { get; set; }
    }
}
