using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceGISLayer.proctblResourceGISLayerDelete.proctblResourceGISLayerDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResource_GISLayerDelete stored procedure.


    public class proctblResourceGISLayerDeleteHandler : IRequestHandler<proctblResourceGISLayerDeleteCommand, IList<tblResourceGISLayer_Resource_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceGISLayerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceGISLayer_Resource_id>> Handle( proctblResourceGISLayerDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceGISLayer_Resource_id> result = await _procedureAdabter
                .Execute<tblResourceGISLayer_Resource_id>("[ProprtyData].proc_tblResource_GISLayerDelete", request);
           

            return result;
        }
    }
}
  