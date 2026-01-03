using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.Store.GetStoreLoadAll;

namespace Application.Inventory.Quiries.Store.GetStoreByOrgeCode
{
    public class GetStoreByCorgCode : IRequest<GetStoreLoadAllListVm>
    {
        public System.Guid Organization { get; set; }
    }
}
