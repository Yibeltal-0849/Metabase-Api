using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionLoadAll;

namespace Application.Finance.Quiries.procFixedAssetEntrustTransaction.GetprocFixedAssetEntrustTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_Entrust_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetEntrustTransactionByPrimaryKey : IRequest<GetprocFixedAssetEntrustTransactionLoadAllListVm>
    {
        public System.Guid Entrust_Trans_ID { get; set; }
    }
}
