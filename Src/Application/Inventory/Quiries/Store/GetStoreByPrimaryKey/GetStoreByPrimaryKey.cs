using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.Store.GetStoreLoadAll;

namespace Application.Inventory.Quiries.Store.GetStoreByPrimaryKey
{
    /// @author  Shimels Alem proc_StoreLoadByPrimaryKey stored procedure.

    public class GetStoreByPrimaryKey : IRequest<GetStoreLoadAllListVm>
    {
        public string Store_code { get; set; }
    }
}
