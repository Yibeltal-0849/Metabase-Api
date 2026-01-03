using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.ProcServiceTopics.GetProcServiceTopicsLoadAll;

namespace Application.Finance.Quiries.ProcServiceTopics.GetProcServiceTopicsByPrimaryKey
{
    ///     /// @author  Shimels Alem proc_Service_TopicsLoadByPrimaryKey stored procedure.

    public class GetProcServiceTopicsByPrimaryKey : IRequest<GetProcServiceTopicsLoadAllListVm>
    {
        public System.Guid topic_Code { get; set; }
        public System.Guid service_Code { get; set; }
    }
}
