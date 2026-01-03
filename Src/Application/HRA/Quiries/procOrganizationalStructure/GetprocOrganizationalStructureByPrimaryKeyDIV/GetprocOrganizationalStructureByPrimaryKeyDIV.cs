using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureLoadAll;

namespace Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureByPrimaryKeyDIV
{
    /// @author  Shimels Alem proc_Organizational_StructureLoadByPrimaryKey_DIV stored procedure.

    public class GetprocOrganizationalStructureByPrimaryKeyDIV : IRequest<GetprocOrganizationalStructureLoadAllListVm>
    {
        public System.Guid DIV { get; set; }
    }
}
