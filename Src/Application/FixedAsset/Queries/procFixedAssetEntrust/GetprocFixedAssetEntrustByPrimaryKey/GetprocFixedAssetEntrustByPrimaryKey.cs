using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetEntrust.GetprocFixedAssetEntrustLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrust.GetprocFixedAssetEntrustByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_EntrustLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetEntrustByPrimaryKey : IRequest<GetprocFixedAssetEntrustLoadAllListVm>
    {
        public System.Guid Entrust_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
    }
}
