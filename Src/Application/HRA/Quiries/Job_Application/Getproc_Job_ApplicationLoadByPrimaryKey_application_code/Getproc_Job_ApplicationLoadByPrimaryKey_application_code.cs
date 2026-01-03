using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Job_Application.GetJob_ApplicationLoadAll;

namespace XOKA.Application.HRA.Quiries.Job_Application.Getproc_Job_ApplicationLoadByPrimaryKey_application_code
{
    /// @author  Shimels Alem  proc_Job_ApplicationLoadByPrimaryKey_application_code stored procedure.

    public class Getproc_Job_ApplicationLoadByPrimaryKey_application_code : IRequest<GetJob_ApplicationLoadAllListVm>
    {
        public Guid application_code { get; set; }
    }
}
