using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Queries.procAdjudicated.GetprocAdjudicatedLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Queries.procAdjudicated.GetprocAdjudicatedLoadByPrimaryKey
{
    public class GetprocAdjudicatedQueryHandler : IRequestHandler<GetprocAdjudicatedByPrimaryKey, GetprocAdjudicatedLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAdjudicatedQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdjudicatedLoadAllListVm> Handle(GetprocAdjudicatedByPrimaryKey request, CancellationToken cancellationToken)
        {

            IList<Adjudicated> procAdjudicated = await _procedureAdabter
               .Execute<Adjudicated>("[dbo].[proc_Plot_AdjudicatedLoadBy_Adjudicated_Code]", request);
            GetprocAdjudicatedLoadAllListVm vm = new GetprocAdjudicatedLoadAllListVm
            {
                procAdjudicated = _mapper.Map<IList<Adjudicated>, IList<GetprocAdjudicatedLoadAllVm>>(procAdjudicated)
            };

            return vm;
        }
    }
}
