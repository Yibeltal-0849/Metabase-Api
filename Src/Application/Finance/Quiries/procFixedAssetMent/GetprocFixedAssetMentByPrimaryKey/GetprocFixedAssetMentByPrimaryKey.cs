using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procFixedAssetMent.GetprocFixedAssetMentLoadAll;

namespace Application.Finance.Quiries.procFixedAssetMent.GetprocFixedAssetMentByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_MentLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetMentByPrimaryKey : IRequest<GetprocFixedAssetMentLoadAllListVm>
    {
        public string Maintainance_ID { get; set; }
    }
}
