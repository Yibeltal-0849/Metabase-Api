using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPJobLineType.GetprocPJobLineTypeLoadAll;

namespace Application.Finance.Quiries.procPJobLineType.GetprocPJobLineTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_P_Job_Line_TypeLoadByPrimaryKey stored procedure.

    public class GetprocPJobLineTypeByPrimaryKey : IRequest<GetprocPJobLineTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
