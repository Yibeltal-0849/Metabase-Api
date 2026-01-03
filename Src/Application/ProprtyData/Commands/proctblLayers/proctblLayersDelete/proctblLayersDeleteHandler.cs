using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblLayers.proctblLayersDelete.proctblLayersDeleteCommand
{

    /// @author  Shimels Alem  proc_tblLayersDelete stored procedure.


    public class proctblLayersDeleteHandler : IRequestHandler<proctblLayersDeleteCommand, IList<tblLayers_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblLayersDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblLayers_id>> Handle( proctblLayersDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblLayers_id> result = await _procedureAdabter
                .Execute<tblLayers_id>("[ProprtyData].proc_tblLayersDelete", request);
           

            return result;
        }
    }
}
  