using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.aspnetRolesCreateRole.GetaspnetRolesCreateRoleLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.aspnetRolesCreateRole.GetaspnetRolesCreateRoleByPrimaryKey
{
    public class GetaspnetRolesCreateRoleQueryHandler : IRequestHandler<GetaspnetRolesCreateRoleByPrimaryKey, GetaspnetRolesCreateRoleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetaspnetRolesCreateRoleQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetaspnetRolesCreateRoleLoadAllListVm> Handle(GetaspnetRolesCreateRoleByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<aspnetRoles> aspnetRolesCreateRoles = await _procedureAdabter
               .Execute<aspnetRoles>("[dbo].[aspnet_Roles_GetAllRoles]", request);
            GetaspnetRolesCreateRoleLoadAllListVm vm = new GetaspnetRolesCreateRoleLoadAllListVm
            {
                aspnetRolesCreateRoles = _mapper.Map<IList<aspnetRoles>, IList<GetaspnetRolesCreateRoleLoadAllVm>>(aspnetRolesCreateRoles)
            };

            return vm;
        }
    }
}
