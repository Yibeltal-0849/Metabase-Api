using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.GetprocFixedAssetMaintTransactionLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetMaintTransaction.procFixedAssetMaintTransactionLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Fixed_Asset_Maint_TransactionLoadByPrimaryKey_Application_Number stored procedure.

    public class procFixedAssetMaintTransactionLoadByPrimaryKeyApplicationNumber : IRequest<GetprocFixedAssetMaintTransactionLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
