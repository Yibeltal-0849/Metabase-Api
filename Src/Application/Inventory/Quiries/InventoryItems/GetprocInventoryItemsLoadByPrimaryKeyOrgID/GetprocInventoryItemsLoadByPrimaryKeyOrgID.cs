using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.InventoryItems.GetInventoryItemsLoadAll;

namespace Application.Inventory.Quiries.InventoryItems.GetprocInventoryItemsLoadByPrimaryKeyOrgID
{
    /// @author  Shimels Alem proc_Inventory_ItemsLoadByPrimaryKey_OrgID stored procedure.

    public class GetprocInventoryItemsLoadByPrimaryKeyOrgID : IRequest<GetInventoryItemsLoadAllListVm>
    {
        public System.Guid OrgID { get; set; }
    }
}
