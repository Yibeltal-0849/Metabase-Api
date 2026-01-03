using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceGISLayer.GetproctblResourceGISLayerLoadAll
{
    class GetproctblResourceGISLayerLoadAllQueryHandler : IRequestHandler<GetproctblResourceGISLayerLoadAllQuery, GetproctblResourceGISLayerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceGISLayerLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceGISLayerLoadAllListVm> Handle(GetproctblResourceGISLayerLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceGISLayer> proctblResourceGISLayers = await _procedureAdabter
               .Execute<tblResourceGISLayer>("[ProprtyData].[proc_tblResource_GISLayerLoadAll]");
            GetproctblResourceGISLayerLoadAllListVm vm = new GetproctblResourceGISLayerLoadAllListVm
            {
                proctblResourceGISLayers = _mapper.Map<IList<tblResourceGISLayer>, IList<GetproctblResourceGISLayerLoadAllVm>>(proctblResourceGISLayers)
            };

            return vm;
        }
    }
}
