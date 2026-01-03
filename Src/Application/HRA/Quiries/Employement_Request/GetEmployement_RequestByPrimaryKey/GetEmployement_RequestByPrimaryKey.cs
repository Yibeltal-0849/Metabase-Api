using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Employement_Request.GetEmployement_RequestLoadAll;

namespace XOKA.Application.HRA.Quiries.Employement_Request.GetEmployement_RequestByPrimaryKey
{
    /// @author  Shimels Alem  proc_Employement_RequestLoadByPrimaryKey stored procedure.

    public class GetEmployement_RequestByPrimaryKey : IRequest<GetEmployement_RequestLoadAllListVm>
    {
        public System.Guid JOBPost_ID { get; set; }
    }
}
