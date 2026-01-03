using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFacilityGISLayer.GetproctblFacilityGISLayerLoadAll
{
    class GetproctblFacilityGISLayerLoadAllQueryHandler : IRequestHandler<GetproctblFacilityGISLayerLoadAllQuery, GetproctblFacilityGISLayerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblFacilityGISLayerLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFacilityGISLayerLoadAllListVm> Handle(GetproctblFacilityGISLayerLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblFacilityGISLayer> proctblFacilityGISLayers = await _procedureAdabter
               .Execute<tblFacilityGISLayer>("[ProprtyData].[proc_tblFacility_GISLayerLoadAll]");
            GetproctblFacilityGISLayerLoadAllListVm vm = new GetproctblFacilityGISLayerLoadAllListVm
            {
                proctblFacilityGISLayers = _mapper.Map<IList<tblFacilityGISLayer>, IList<GetproctblFacilityGISLayerLoadAllVm>>(proctblFacilityGISLayers)
            };

            return vm;
        }
    }
}
