using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Finance.Quiries.ProcServiceTopics.GetProcServiceTopicsLoadAll
{
    /// @author  Shimels Alem  proc_Service_TopicsLoadAll stored procedure.

    public class GetProcServiceTopicsLoadAllListVm
    {
        public IList<GetProcServiceTopicsLoadAllVm> ProcServiceTopicss { get; set; }
    }
}
