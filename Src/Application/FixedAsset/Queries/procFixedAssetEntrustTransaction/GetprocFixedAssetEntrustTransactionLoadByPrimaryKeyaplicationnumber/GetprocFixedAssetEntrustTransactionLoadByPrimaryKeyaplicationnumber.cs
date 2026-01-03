using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadByPrimaryKeyaplicationnumber
{
    /// @author  Shimels Alem proc_Fixed_Asset_Entrust_TransactionLoadByPrimaryKey_aplication_number stored procedure.

    public class GetprocFixedAssetEntrustTransactionLoadByPrimaryKeyaplicationnumber : IRequest<GetprocFixedAssetEntrustTransactionLoadAllListVm>
    {
        public string application_number { get; set; }
    }
}
