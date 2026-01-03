using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procPropertyRegistration.GetprocPropertyRegistrationLoadAll
{
    class GetprocPropertyRegistrationLoadAllQueryHandler : IRequestHandler<GetprocPropertyRegistrationLoadAllQuery, GetprocPropertyRegistrationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPropertyRegistrationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPropertyRegistrationLoadAllListVm> Handle(GetprocPropertyRegistrationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PropertyRegistration> procPropertyRegistrations = await _procedureAdabter
               .Execute<PropertyRegistration>("[dbo].[proc_Property_RegistrationLoadAll]");
            GetprocPropertyRegistrationLoadAllListVm vm = new GetprocPropertyRegistrationLoadAllListVm
            {
                procPropertyRegistrations = _mapper.Map<IList<PropertyRegistration>, IList<GetprocPropertyRegistrationLoadAllVm>>(procPropertyRegistrations)
            };

            return vm;
        }
    }
}
