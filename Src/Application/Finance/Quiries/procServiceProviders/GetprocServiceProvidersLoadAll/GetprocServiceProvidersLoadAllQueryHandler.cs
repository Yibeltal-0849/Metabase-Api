using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procServiceProviders.GetprocServiceProvidersLoadAll
{
    class GetprocServiceProvidersLoadAllQueryHandler : IRequestHandler<GetprocServiceProvidersLoadAllQuery, GetprocServiceProvidersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocServiceProvidersLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocServiceProvidersLoadAllListVm> Handle(GetprocServiceProvidersLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Service_Providers> procServiceProviderss = await _procedureAdabter
               .Execute<Service_Providers>("[FINA].[proc_Service_ProvidersLoadByPrimaryKey]");
            GetprocServiceProvidersLoadAllListVm vm = new GetprocServiceProvidersLoadAllListVm
            {
                procServiceProviderss = _mapper.Map<IList<Service_Providers>, IList<GetprocServiceProvidersLoadAllVm>>(procServiceProviderss)
            };

            return vm;
        }
    }
}
