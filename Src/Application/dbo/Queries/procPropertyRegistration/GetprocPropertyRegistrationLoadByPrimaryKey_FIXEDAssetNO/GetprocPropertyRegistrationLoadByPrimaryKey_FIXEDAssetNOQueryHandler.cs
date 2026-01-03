using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.procPropertyRegistration.GetprocPropertyRegistrationLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procPropertyRegistration.GetprocPropertyRegistrationLoadByPrimaryKey_FIXEDAssetNO
{
    public class GetprocPropertyRegistrationQueryHandler : IRequestHandler<GetprocPropertyRegistrationLoadByPrimaryKey_FIXEDAssetNO, GetprocPropertyRegistrationLoadAllListVm2>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPropertyRegistrationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPropertyRegistrationLoadAllListVm2> Handle(GetprocPropertyRegistrationLoadByPrimaryKey_FIXEDAssetNO request, CancellationToken cancellationToken)
        {
           
            IList<PropertyRegistration2> procPropertyRegistrations = await _procedureAdabter
               .Execute<PropertyRegistration2>("[dbo].[proc_Property_RegistrationLoadByPrimaryKey_FIXED_Asset_NO]", request);
            GetprocPropertyRegistrationLoadAllListVm2 vm = new GetprocPropertyRegistrationLoadAllListVm2
            {
                procPropertyRegistrations = _mapper.Map<IList<PropertyRegistration2>, IList<GetprocPropertyRegistrationLoadAllVm2>>(procPropertyRegistrations)
            };

            return vm;
        }
    }
}
