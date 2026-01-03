using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetManagementTransaction.GetprocFixedAssetManagementTransactionLoadByPrimaryKeyApplcaitionnumber
{
    /// @author  Shimels Alem proc_Fixed_Asset_Management_TransactionLoadByPrimaryKey_Applcaition_number stored procedure.

    public class GetprocFixedAssetManagementTransactionLoadByPrimaryKeyApplcaitionnumber : IRequest<GetprocFixedAssetManagementTransactionLoadAllListVm>
    {
        public string Applcaition_number { get; set; }
    }
}
