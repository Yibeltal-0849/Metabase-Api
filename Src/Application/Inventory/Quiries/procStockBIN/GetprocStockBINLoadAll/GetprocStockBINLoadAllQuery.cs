using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Inventory.Quiries.procStockBIN.GetprocStockBINLoadAll
{
    public class GetprocStockBINLoadAllQuery : IRequest<GetprocStockBINLoadAllListVm>
    {
        public System.Guid Organization { get; set; }
        
    }
}
