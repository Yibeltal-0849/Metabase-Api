using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureLoadAll;

namespace Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureByPrimaryKey
{
    /// @author  Shimels Alem proc_Organizational_StructureLoadByPrimaryKey stored procedure.

    public class GetprocOrganizationalStructureByPrimaryKey : IRequest<GetprocOrganizationalStructureLoadAllListVm>
    {
        public System.Guid Structure_ID { get; set; }
    }
}
