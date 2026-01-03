using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadAll;

namespace Application.Finance.Quiries.procPurchaseLine.GetprocPurchaseLineLoadByPrimaryKeyTransNO
{
    /// @author  Shimels Alem proc_Purchase_LineLoadByPrimaryKey_Trans_NO stored procedure.

    public class GetprocPurchaseLineLoadByPrimaryKeyTransNO : IRequest<GetprocPurchaseLineLoadAllListVm>
    {
        public string Trans_NO { get; set; }
    }
}
