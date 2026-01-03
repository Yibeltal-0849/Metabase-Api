using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.ProcorganizationType.GetProcorganizationTypeLoadAll;

namespace Application.Finance.Quiries.ProcorganizationType.GetProcorganizationTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_organization_TypeLoadByPrimaryKey stored procedure.

    public class GetProcorganizationTypeByPrimaryKey : IRequest<GetProcorganizationTypeLoadAllListVm>
    {
        public System.Guid organization_Type_Code { get; set; }
    }
}
