using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadAll;

namespace Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineByPrimaryKey
{
    /// @author  Shimels Alem proc_Purchase_LineLoadByPrimaryKey stored procedure.

    public class GetprocPurchaseLineByPrimaryKey : IRequest<GetprocPurchaseLineLoadAllListVm>
    {
        public System.Guid Purchase_Line_ID { get; set; }
    }
}
