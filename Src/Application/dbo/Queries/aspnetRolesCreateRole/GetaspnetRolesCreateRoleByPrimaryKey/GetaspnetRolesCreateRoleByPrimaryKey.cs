using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.aspnetRolesCreateRole.GetaspnetRolesCreateRoleLoadAll;

namespace Application.dbo.Quiries.aspnetRolesCreateRole.GetaspnetRolesCreateRoleByPrimaryKey
{
    /// @author  Shimels Alem aspnet_Roles_GetAllRoles stored procedure.

    public class GetaspnetRolesCreateRoleByPrimaryKey : IRequest<GetaspnetRolesCreateRoleLoadAllListVm>
    {
        public string ApplicationName { get; set; }
    }
}
