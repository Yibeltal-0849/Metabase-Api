using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadAll;

namespace Application.Finance.Quiries.procorganizations.GetprocorganizationsByPrimaryKey
{
    ///     /// @author  Shimels Alem GetprocorganizationsByPrimaryKey stored procedure.

    public class GetprocorganizationsByPrimaryKey : IRequest<GetprocorganizationsLoadAllListVm>
    {
       public Guid organization_Code { get; set; }
    }
}
