using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_Management_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetManagementTransactionByPrimaryKey : IRequest<GetprocFixedAssetManagementTransactionLoadAllListVm>
    {
        public System.Guid FixedAsset_Trans_ID { get; set; }
    }
}
