using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procapplications.GetprocapplicationsLoadAll;

namespace Application.dbo.Quiries.procapplications.GetprocapplicationsByPrimaryKey
{
    /// @author  Shimels Alem proc_applicationsLoadByPrimaryKey stored procedure.

    public class GetprocapplicationsByPrimaryKey : IRequest<GetprocapplicationsLoadAllListVm>
    {
        public System.Guid application_code { get; set; }
    }
}
