using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procSafetySecurity.GetprocSafetySecurityLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procSafetySecurity.GetprocSafetySecurityByPrimaryKey
{
    public class GetprocSafetySecurityQueryHandler : IRequestHandler<GetprocSafetySecurityByPrimaryKey, GetprocSafetySecurityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSafetySecurityQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSafetySecurityLoadAllListVm> Handle(GetprocSafetySecurityByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SafetySecurity> procSafetySecuritys = await _procedureAdabter
               .Execute<SafetySecurity>("[Vehicle].[proc_Safety_SecurityLoadByPrimaryKey]", request);
            GetprocSafetySecurityLoadAllListVm vm = new GetprocSafetySecurityLoadAllListVm
            {
                procSafetySecuritys = _mapper.Map<IList<SafetySecurity>, IList<GetprocSafetySecurityLoadAllVm>>(procSafetySecuritys)
            };

            return vm;
        }
    }
}
