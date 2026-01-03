using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemTransferDetail.GetprocItemTransferDetailLoadAll;

namespace Application.Inventory.Quiries.procItemTransferDetail.GetprocItemTransferDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Item_Transfer_DetailLoadByPrimaryKey stored procedure.

    public class GetprocItemTransferDetailByPrimaryKey : IRequest<GetprocItemTransferDetailLoadAllListVm>
    {
        public string Transfer_Req_DetailID { get; set; }
    }
}
