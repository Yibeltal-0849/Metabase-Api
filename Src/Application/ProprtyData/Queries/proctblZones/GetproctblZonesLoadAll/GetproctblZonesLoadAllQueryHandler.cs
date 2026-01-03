using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblZones.GetproctblZonesLoadAll
{
    class GetproctblZonesLoadAllQueryHandler : IRequestHandler<GetproctblZonesLoadAllQuery, GetproctblZonesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblZonesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblZonesLoadAllListVm> Handle(GetproctblZonesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblZones> proctblZoness = await _procedureAdabter
               .Execute<tblZones>("[ProprtyData].[proc_tblZonesLoadAll]");
            GetproctblZonesLoadAllListVm vm = new GetproctblZonesLoadAllListVm
            {
                proctblZoness = _mapper.Map<IList<tblZones>, IList<GetproctblZonesLoadAllVm>>(proctblZoness)
            };

            return vm;
        }
    }
}
