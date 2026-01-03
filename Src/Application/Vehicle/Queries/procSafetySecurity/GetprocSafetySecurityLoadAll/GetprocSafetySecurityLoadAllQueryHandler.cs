using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procSafetySecurity.GetprocSafetySecurityLoadAll
{
    class GetprocSafetySecurityLoadAllQueryHandler : IRequestHandler<GetprocSafetySecurityLoadAllQuery, GetprocSafetySecurityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSafetySecurityLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSafetySecurityLoadAllListVm> Handle(GetprocSafetySecurityLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SafetySecurity> procSafetySecuritys = await _procedureAdabter
               .Execute<SafetySecurity>("[Vehicle].[proc_Safety_SecurityLoadAll]");
            GetprocSafetySecurityLoadAllListVm vm = new GetprocSafetySecurityLoadAllListVm
            {
                procSafetySecuritys = _mapper.Map<IList<SafetySecurity>, IList<GetprocSafetySecurityLoadAllVm>>(procSafetySecuritys)
            };

            return vm;
        }
    }
}
