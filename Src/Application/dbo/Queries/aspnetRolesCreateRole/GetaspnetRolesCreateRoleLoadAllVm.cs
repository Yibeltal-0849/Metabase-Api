using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Quiries.aspnetRolesCreateRole
{
    public class GetaspnetRolesCreateRoleLoadAllVm : IMapFrom<aspnetRoles>
    {
        public string RoleName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<aspnetRoles, GetaspnetRolesCreateRoleLoadAllVm>();
        }
    }
}
