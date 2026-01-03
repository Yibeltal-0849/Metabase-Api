using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemReturnDetail.GetprocItemReturnDetailLoadAll;

namespace Application.Inventory.Quiries.procItemReturnDetail.GetprocItemReturnDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Item_Return_DetailLoadByPrimaryKey stored procedure.

    public class GetprocItemReturnDetailByPrimaryKey : IRequest<GetprocItemReturnDetailLoadAllListVm>
    {
        public long Request_DetailID { get; set; }
    }
}
