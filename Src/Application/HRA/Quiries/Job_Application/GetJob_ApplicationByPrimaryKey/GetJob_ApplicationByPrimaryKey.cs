using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Job_Application.GetJob_ApplicationLoadAll;

namespace XOKA.Application.HRA.Quiries.Job_Application.GetJob_ApplicationByPrimaryKey
{
    /// @author  Shimels Alem  proc_Job_ApplicationLoadByPrimaryKey stored procedure.

    public class GetJob_ApplicationByPrimaryKey : IRequest<GetJob_ApplicationLoadAllListVm>
    {
        public string Job_AppID { get; set; }
    }
}
