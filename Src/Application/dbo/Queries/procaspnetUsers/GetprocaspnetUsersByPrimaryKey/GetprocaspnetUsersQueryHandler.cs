using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.procaspnetUsers.GetprocaspnetUsersLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procaspnetUsers.GetprocaspnetUsersByPrimaryKey
{
    public class GetprocaspnetUsersQueryHandler : IRequestHandler<GetprocaspnetUsersByPrimaryKey, GetprocaspnetUsersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocaspnetUsersQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocaspnetUsersLoadAllListVm> Handle(GetprocaspnetUsersByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<aspnetUsers> procaspnetUserss = await _procedureAdabter
               .Execute<aspnetUsers>("[dbo].[proc_aspnet_UsersLoadByPrimaryKey]", request);
            GetprocaspnetUsersLoadAllListVm vm = new GetprocaspnetUsersLoadAllListVm
            {
                procaspnetUserss = _mapper.Map<IList<aspnetUsers>, IList<GetprocaspnetUsersLoadAllVm>>(procaspnetUserss)
            };

            return vm;
        }
    }
}
