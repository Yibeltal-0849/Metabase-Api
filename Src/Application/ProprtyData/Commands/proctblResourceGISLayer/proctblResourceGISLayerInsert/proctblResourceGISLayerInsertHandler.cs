



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceGISLayer.proctblResourceGISLayerInsert.proctblResourceGISLayerInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_GISLayerInsert stored procedure.


    public class proctblResourceGISLayerInsertHandler : IRequestHandler<proctblResourceGISLayerInsertCommand, IList<tblResourceGISLayer_Resource_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceGISLayerInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceGISLayer_Resource_id>> Handle( proctblResourceGISLayerInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceGISLayer_Resource_id> result = await _procedureAdabter
                .Execute<tblResourceGISLayer_Resource_id>("[ProprtyData].proc_tblResource_GISLayerInsert", request);
           

            return result;
        }
    }
}
 