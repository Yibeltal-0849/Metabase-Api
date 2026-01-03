using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.cItems.GetcItemsLoadAll;

namespace Application.Inventory.Quiries.cItems.GetcItemsByPrimaryKey
{
    /// @author  Shimels Alem proc_c_ItemsLoadByPrimaryKey stored procedure.

    public class GetcItemsByPrimaryKey : IRequest<GetcItemsLoadAllListVm>
    {
        public string Item_Id { get; set; }
    }
}
