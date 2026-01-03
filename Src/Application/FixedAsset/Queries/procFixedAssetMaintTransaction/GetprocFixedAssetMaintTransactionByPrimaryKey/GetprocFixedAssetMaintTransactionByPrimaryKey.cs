using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.GetprocFixedAssetMaintTransactionLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.GetprocFixedAssetMaintTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_Maint_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetMaintTransactionByPrimaryKey : IRequest<GetprocFixedAssetMaintTransactionLoadAllListVm>
    {
        public System.Guid FixedAsset_Maintan_Trans_ID { get; set; }
    }
}
