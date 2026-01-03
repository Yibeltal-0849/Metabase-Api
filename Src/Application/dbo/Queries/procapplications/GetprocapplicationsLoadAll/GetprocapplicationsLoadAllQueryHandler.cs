using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procapplications.GetprocapplicationsLoadAll
{
    class GetprocapplicationsLoadAllQueryHandler : IRequestHandler<GetprocapplicationsLoadAllQuery, GetprocapplicationsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocapplicationsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocapplicationsLoadAllListVm> Handle(GetprocapplicationsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<applications> procapplicationss = await _procedureAdabter
               .Execute<applications>("[dbo].[proc_applicationsLoadAll]");
            GetprocapplicationsLoadAllListVm vm = new GetprocapplicationsLoadAllListVm
            {
                procapplicationss = _mapper.Map<IList<applications>, IList<GetprocapplicationsLoadAllVm>>(procapplicationss)
            };

            return vm;
        }
    }
}
