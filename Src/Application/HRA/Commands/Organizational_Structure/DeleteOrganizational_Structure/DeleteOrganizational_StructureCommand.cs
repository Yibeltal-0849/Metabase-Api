using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Organizational_Structure.DeleteOrganizational_Structure
{
    /// @author  Shimels Alem  DeleteCOrganizational_Structure stored procedure.
    
    public class DeleteOrganizational_StructureCommand : IRequest<IList<OrganizationalStructure_Structure_ID>>
    {
        public Guid Structure_ID { get; set; }
    }
}
