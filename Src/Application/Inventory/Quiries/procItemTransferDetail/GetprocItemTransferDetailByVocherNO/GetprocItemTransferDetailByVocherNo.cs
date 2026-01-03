using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemTransferDetail.GetprocItemTransferDetailLoadAll;

namespace Application.Inventory.Quiries.procItemTransferDetail.GetprocItemTransferDetailByVocherNO
{
    public class GetprocItemTransferDetailByVocherNo : IRequest<GetprocItemTransferDetailLoadAllListVm>
    {
        public string Vocher_NO { get; set; }
    }
}