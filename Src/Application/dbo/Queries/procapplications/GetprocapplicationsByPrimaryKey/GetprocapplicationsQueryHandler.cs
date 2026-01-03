using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.procapplications.GetprocapplicationsLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procapplications.GetprocapplicationsByPrimaryKey
{
    public class GetprocapplicationsQueryHandler : IRequestHandler<GetprocapplicationsByPrimaryKey, GetprocapplicationsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocapplicationsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocapplicationsLoadAllListVm> Handle(GetprocapplicationsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<applications> procapplicationss = await _procedureAdabter
               .Execute<applications>("[dbo].[proc_applicationsLoadByPrimaryKey]", request);
            GetprocapplicationsLoadAllListVm vm = new GetprocapplicationsLoadAllListVm
            {
                procapplicationss = _mapper.Map<IList<applications>, IList<GetprocapplicationsLoadAllVm>>(procapplicationss)
            };

            return vm;
        }
    }
}
