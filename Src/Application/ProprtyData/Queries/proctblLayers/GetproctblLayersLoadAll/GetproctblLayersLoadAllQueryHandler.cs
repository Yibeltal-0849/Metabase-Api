using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblLayers.GetproctblLayersLoadAll
{
    class GetproctblLayersLoadAllQueryHandler : IRequestHandler<GetproctblLayersLoadAllQuery, GetproctblLayersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblLayersLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblLayersLoadAllListVm> Handle(GetproctblLayersLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblLayers> proctblLayerss = await _procedureAdabter
               .Execute<tblLayers>("[ProprtyData].[proc_tblLayersLoadAll]");
            GetproctblLayersLoadAllListVm vm = new GetproctblLayersLoadAllListVm
            {
                proctblLayerss = _mapper.Map<IList<tblLayers>, IList<GetproctblLayersLoadAllVm>>(proctblLayerss)
            };

            return vm;
        }
    }
}
