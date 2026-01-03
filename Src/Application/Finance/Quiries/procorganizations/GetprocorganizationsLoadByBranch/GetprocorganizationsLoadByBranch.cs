using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadAll;

namespace Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadByBranch
{
    /// <summary>
    /// @author [Your Name] GetprocorganizationsLoadByBranch stored procedure.
    /// </summary>
    public class GetprocorganizationsLoadByBranch : IRequest<GetprocorganizationsLoadAllListVm>
    {
        public System.Guid? organizations_Organization_Code { get; set; }
    }
}