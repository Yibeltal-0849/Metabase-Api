using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procaspnetUsers.Getproc_aspnet_Usersavalable_to_Link_with_HR
{
    class Getproc_aspnet_Usersavalable_to_Link_with_HRQueryHandler : IRequestHandler<Getproc_aspnet_Usersavalable_to_Link_with_HRQuery, Getproc_aspnet_Usersavalable_to_Link_with_HRVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public Getproc_aspnet_Usersavalable_to_Link_with_HRQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Getproc_aspnet_Usersavalable_to_Link_with_HRVm> Handle(Getproc_aspnet_Usersavalable_to_Link_with_HRQuery request, CancellationToken cancellationToken)
        {
            IList<aspnetUsers> procaspnetUserss = await _procedureAdabter
               .Execute<aspnetUsers>("[dbo].[proc_aspnet_Usersavalable_to_Link_with_HR]");
            Getproc_aspnet_Usersavalable_to_Link_with_HRVm vm = new Getproc_aspnet_Usersavalable_to_Link_with_HRVm
            {
                procaspnetUserss = _mapper.Map<IList<aspnetUsers>, IList<GetprocaspnetUsersLoadAllVm>>(procaspnetUserss)
            };

            return vm;
        }
    }
}
