using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetMent.GetprocFixedAssetMentLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetMent.GetprocFixedAssetMentByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_MentLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetMentByPrimaryKey : IRequest<GetprocFixedAssetMentLoadAllListVm>
    {
        public string Maintainance_ID { get; set; }
    }
}
