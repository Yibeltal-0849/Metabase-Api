using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.cItems.GetcItemsLoadAll;

namespace Application.Inventory.Quiries.cItems.GetproccItemsLoadByPrimaryKeyApplicationNo
{
    /// @author  Shimels Alem proc_c_ItemsLoadByPrimaryKey_Application_No stored procedure.

    public class GetproccItemsLoadByPrimaryKeyApplicationNo : IRequest<GetcItemsLoadAllListVm>
    {
        public string Application_No { get; set; }
    }
}
