using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.PerchaseContract.GetPerchaseContractLoadAll;

namespace Application.Purchase.Quiries.PerchaseContract.GetprocPerchaseContractLoadByPrimaryKeyBidAwardID
{
    /// @author  Shimels Alem proc_Perchase_ContractLoadByPrimaryKey_Bid_Award_ID stored procedure.

    public class GetprocPerchaseContractLoadByPrimaryKeyBidAwardID : IRequest<GetPerchaseContractLoadAllListVm>
    {
        public System.Guid Bid_Award_ID { get; set; }
    }
}
