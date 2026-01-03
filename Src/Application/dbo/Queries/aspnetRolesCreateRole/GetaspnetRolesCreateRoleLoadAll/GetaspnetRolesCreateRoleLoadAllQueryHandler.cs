using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.aspnetRolesCreateRole.GetaspnetRolesCreateRoleLoadAll
{
    class GetaspnetRolesCreateRoleLoadAllQueryHandler : IRequestHandler<GetaspnetRolesCreateRoleLoadAllQuery, GetaspnetRolesCreateRoleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetaspnetRolesCreateRoleLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetaspnetRolesCreateRoleLoadAllListVm> Handle(GetaspnetRolesCreateRoleLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<aspnetRoles> aspnetRolesCreateRoles = await _procedureAdabter
               .Execute<aspnetRoles>("[dbo].[aspnet_Roles_GetAllRoles]");
            GetaspnetRolesCreateRoleLoadAllListVm vm = new GetaspnetRolesCreateRoleLoadAllListVm
            {
                aspnetRolesCreateRoles = _mapper.Map<IList<aspnetRoles>, IList<GetaspnetRolesCreateRoleLoadAllVm>>(aspnetRolesCreateRoles)
            };

            return vm;
        }
    }
}
