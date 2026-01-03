using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureByOrgCode
{
    public class GetprocOrganizationalStructureLoadByOrgCodeAllVm : IMapFrom<OrganizationalStructureOrgCode>
    {
        public System.Guid Structure_ID { get; set; }
        public System.Guid? DIV { get; set; }
        public string Job_Position { get; set; }
        public string RoleName { get; set; }
        public string Eductional_Criteria { get; set; }
        public string Experiance_Criteria { get; set; }
        public string Training_Criteria { get; set; }
        public int? Addtional_Empolye_Needed { get; set; }
        public bool? Is_Active { get; set; }
        public string Remark { get; set; }
        public double Basic_Salary { get; set; }

        public double? OT_Amount { get; set; }
        public string Provision { get; set; }
        public System.Guid organization_code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrganizationalStructureOrgCode, GetprocOrganizationalStructureLoadByOrgCodeAllVm>();
        }
    }
}
