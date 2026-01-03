using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetLoadByPrimaryKeyOrgID
{
    /// @author  Shimels Alem proc_Fixed_AssetLoadByPrimaryKey_OrgID stored procedure.

    public class GetprocFixedAssetLoadByPrimaryKeyOrgID : IRequest<GetprocFixedAssetLoadAllListVm>
    {
        public System.Guid OrgID { get; set; }
    }
}
