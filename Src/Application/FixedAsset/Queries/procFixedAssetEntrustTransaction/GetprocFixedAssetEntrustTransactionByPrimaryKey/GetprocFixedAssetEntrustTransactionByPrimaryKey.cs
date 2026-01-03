using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_Entrust_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetEntrustTransactionByPrimaryKey : IRequest<GetprocFixedAssetEntrustTransactionLoadAllListVm>
    {
        public System.Guid Entrust_Trans_ID { get; set; }
    }
}
