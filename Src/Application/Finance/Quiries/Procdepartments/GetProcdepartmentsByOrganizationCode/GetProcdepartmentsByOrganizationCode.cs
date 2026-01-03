using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.Procdepartments.GetProcdepartmentsLoadAll;

namespace Application.Finance.Quiries.Procdepartments.GetProcdepartmentsByOrganizationCode
{
    public class GetProcdepartmentsByOrganizationCode : IRequest<GetProcdepartmentsLoadAllListVm>
    {
        public Guid organizations_Organization_Code { get; set; }
    }
}
