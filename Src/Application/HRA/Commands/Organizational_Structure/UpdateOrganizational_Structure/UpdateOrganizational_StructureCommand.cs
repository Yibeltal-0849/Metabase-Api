using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Organizational_Structure.UpdateOrganizational_Structure
{
    /// @author  Shimels Alem  UpdateCOrganizational_Structure stored procedure.
    
    public class UpdateOrganizational_StructureCommand : IRequest<IList<OrganizationalStructure_Structure_ID>>
    {
        public Guid Structure_ID { get; set; }
        public Guid? DIV { get; set; }
        public Guid? Job_Position { get; set; }
        public string RoleName { get; set; }
        public string Eductional_Criteria { get; set; }
        public string Experiance_Criteria { get; set; }
        public string Training_Criteria { get; set; }
        public int? Addtional_Empolye_Needed { get; set; }
        public bool? Is_Active { get; set; }
        public string Remark { get; set; }
        //public double Basic_Salary { get; set; }
        //public double? OT_Amount { get; set; }
        //public string Provision { get; set; }
    }
}
