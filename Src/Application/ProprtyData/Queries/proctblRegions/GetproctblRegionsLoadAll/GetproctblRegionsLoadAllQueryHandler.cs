using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblRegions.GetproctblRegionsLoadAll
{
    class GetproctblRegionsLoadAllQueryHandler : IRequestHandler<GetproctblRegionsLoadAllQuery, GetproctblRegionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblRegionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblRegionsLoadAllListVm> Handle(GetproctblRegionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblRegions> proctblRegionss = await _procedureAdabter
               .Execute<tblRegions>("[ProprtyData].[proc_tblRegionsLoadAll]");
            GetproctblRegionsLoadAllListVm vm = new GetproctblRegionsLoadAllListVm
            {
                proctblRegionss = _mapper.Map<IList<tblRegions>, IList<GetproctblRegionsLoadAllVm>>(proctblRegionss)
            };

            return vm;
        }
    }
}
