using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblRegions.GetproctblRegionsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblRegions.GetproctblRegionsByPrimaryKey
{
    public class GetproctblRegionsQueryHandler : IRequestHandler<GetproctblRegionsByPrimaryKey, GetproctblRegionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblRegionsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblRegionsLoadAllListVm> Handle(GetproctblRegionsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblRegions> proctblRegionss = await _procedureAdabter
               .Execute<tblRegions>("[ProprtyData].[proc_tblRegionsLoadByPrimaryKey]", request);
            GetproctblRegionsLoadAllListVm vm = new GetproctblRegionsLoadAllListVm
            {
                proctblRegionss = _mapper.Map<IList<tblRegions>, IList<GetproctblRegionsLoadAllVm>>(proctblRegionss)
            };

            return vm;
        }
    }
}
