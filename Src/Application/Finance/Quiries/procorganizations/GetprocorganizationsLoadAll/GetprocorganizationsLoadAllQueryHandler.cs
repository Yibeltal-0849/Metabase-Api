using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadAll
{
    class GetCprocorganizationsLoadAllQueryHandler : IRequestHandler<GetprocorganizationsLoadAllQuery, GetprocorganizationsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCprocorganizationsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocorganizationsLoadAllListVm> Handle(GetprocorganizationsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_procorganizations> procorganizationss = await _procedureAdabter
               .Execute<_procorganizations>("[dbo].[proc_organizationsLoadAll]");
            GetprocorganizationsLoadAllListVm vm = new GetprocorganizationsLoadAllListVm
            {
                procorganizationss = _mapper.Map<IList<_procorganizations>, IList<GetprocorganizationsLoadAllVm>>(procorganizationss)
            };

            return vm;
        }
    }
}
