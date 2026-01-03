using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblZones.GetproctblZonesLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblZones.GetproctblZonesByPrimaryKey
{
    public class GetproctblZonesQueryHandler : IRequestHandler<GetproctblZonesByPrimaryKey, GetproctblZonesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblZonesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblZonesLoadAllListVm> Handle(GetproctblZonesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblZones> proctblZoness = await _procedureAdabter
               .Execute<tblZones>("[ProprtyData].[proc_tblZonesLoadByPrimaryKey]", request);
            GetproctblZonesLoadAllListVm vm = new GetproctblZonesLoadAllListVm
            {
                proctblZoness = _mapper.Map<IList<tblZones>, IList<GetproctblZonesLoadAllVm>>(proctblZoness)
            };

            return vm;
        }
    }
}
