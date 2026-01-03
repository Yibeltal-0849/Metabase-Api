using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;
namespace Application.dbo.Queries.procAdjudicated.GetprocAdjudicatedLoadAll
{
    public class GetprocAdjudicatedLoadAllQueryHandler : IRequestHandler<GetprocAdjudicatedLoadAllQuery, GetprocAdjudicatedLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdjudicatedLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdjudicatedLoadAllListVm> Handle(GetprocAdjudicatedLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Adjudicated> procAdjudicated = await _procedureAdabter
               .Execute<Adjudicated>("[dbo].[proc_Plot_AdjudicatedLoadAll]");
            GetprocAdjudicatedLoadAllListVm vm = new GetprocAdjudicatedLoadAllListVm
            {
                procAdjudicated = _mapper.Map<IList<Adjudicated>, IList<GetprocAdjudicatedLoadAllVm>>(procAdjudicated)
            };

            return vm;
        }
    }
}
