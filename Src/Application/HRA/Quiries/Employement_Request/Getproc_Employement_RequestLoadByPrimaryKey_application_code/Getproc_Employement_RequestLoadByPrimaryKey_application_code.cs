using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Employement_Request.GetEmployement_RequestLoadAll;

namespace XOKA.Application.HRA.Quiries.Employement_Request.Getproc_Employement_RequestLoadByPrimaryKey_application_code
{
    /// @author  Shimels Alem  proc_Employement_RequestLoadByPrimaryKey_application_code stored procedure.

    public class Getproc_Employement_RequestLoadByPrimaryKey_application_code : IRequest<GetEmployement_RequestLoadAllListVm>
    {
        public System.Guid application_code { get; set; }
    }
}
