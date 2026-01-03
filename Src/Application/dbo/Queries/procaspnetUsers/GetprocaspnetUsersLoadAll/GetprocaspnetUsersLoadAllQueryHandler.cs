using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procaspnetUsers.GetprocaspnetUsersLoadAll
{
    class GetprocaspnetUsersLoadAllQueryHandler : IRequestHandler<GetprocaspnetUsersLoadAllQuery, GetprocaspnetUsersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocaspnetUsersLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocaspnetUsersLoadAllListVm> Handle(GetprocaspnetUsersLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<aspnetUsers> procaspnetUserss = await _procedureAdabter
               .Execute<aspnetUsers>("[dbo].[proc_aspnet_UsersLoadAll]");
            GetprocaspnetUsersLoadAllListVm vm = new GetprocaspnetUsersLoadAllListVm
            {
                procaspnetUserss = _mapper.Map<IList<aspnetUsers>, IList<GetprocaspnetUsersLoadAllVm>>(procaspnetUserss)
            };

            return vm;
        }
    }
}
