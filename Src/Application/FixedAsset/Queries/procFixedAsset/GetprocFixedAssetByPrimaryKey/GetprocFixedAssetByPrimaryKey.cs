using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_AssetLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetByPrimaryKey : IRequest<GetprocFixedAssetLoadAllListVm>
    {
        public string FIXED_Asset_No { get; set; }
    }
}
