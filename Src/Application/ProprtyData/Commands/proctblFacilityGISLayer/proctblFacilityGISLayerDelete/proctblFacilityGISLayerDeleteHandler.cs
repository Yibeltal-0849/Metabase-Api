using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFacilityGISLayer.proctblFacilityGISLayerDelete.proctblFacilityGISLayerDeleteCommand
{

    /// @author  Shimels Alem  proc_tblFacility_GISLayerDelete stored procedure.


    public class proctblFacilityGISLayerDeleteHandler : IRequestHandler<proctblFacilityGISLayerDeleteCommand, IList<tblFacilityGISLayer_Facility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityGISLayerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacilityGISLayer_Facility_id>> Handle( proctblFacilityGISLayerDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblFacilityGISLayer_Facility_id> result = await _procedureAdabter
                .Execute<tblFacilityGISLayer_Facility_id>("[ProprtyData].proc_tblFacility_GISLayerDelete", request);
           

            return result;
        }
    }
}
  