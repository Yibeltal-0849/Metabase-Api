using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;

namespace Application.Inventory.Quiries.InventoryItems.GetprocInventoryItemsLoadByPrimaryKeyForPosting
{
    /// @author  Shimels Alem proc_Inventory_ItemsLoadByPrimaryKey_For_Posting stored procedure.

    public class GetprocInventoryItemsLoadByPrimaryKeyForPosting : IRequest<GetInventoryItemsLoadAllListVm>
    {
        public string Inventory_Posting_Group { get; set; }
      
    }
}
