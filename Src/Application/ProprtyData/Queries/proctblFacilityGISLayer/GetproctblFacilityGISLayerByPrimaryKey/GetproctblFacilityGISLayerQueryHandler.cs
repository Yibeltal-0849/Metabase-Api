using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblFacilityGISLayer.GetproctblFacilityGISLayerLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFacilityGISLayer.GetproctblFacilityGISLayerByPrimaryKey
{
    public class GetproctblFacilityGISLayerQueryHandler : IRequestHandler<GetproctblFacilityGISLayerByPrimaryKey, GetproctblFacilityGISLayerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblFacilityGISLayerQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFacilityGISLayerLoadAllListVm> Handle(GetproctblFacilityGISLayerByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblFacilityGISLayer> proctblFacilityGISLayers = await _procedureAdabter
               .Execute<tblFacilityGISLayer>("[ProprtyData].[proc_tblFacility_GISLayerLoadByPrimaryKey]", request);
            GetproctblFacilityGISLayerLoadAllListVm vm = new GetproctblFacilityGISLayerLoadAllListVm
            {
                proctblFacilityGISLayers = _mapper.Map<IList<tblFacilityGISLayer>, IList<GetproctblFacilityGISLayerLoadAllVm>>(proctblFacilityGISLayers)
            };

            return vm;
        }
    }
}
