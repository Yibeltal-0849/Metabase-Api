using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureLoadAll;

namespace Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureByOrgCode
{
    public class GetprocOrganizationalStructureByOrgCode : IRequest<GetprocOrganizationalStructureLoadByOgrCodeAllListVm>
    {
        public System.Guid organization_code { get; set; }
    }
}
