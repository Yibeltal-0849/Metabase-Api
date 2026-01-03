

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblFacilityGISLayer.proctblFacilityGISLayerUpdate.proctblFacilityGISLayerUpdateCommand
{

    /// @author  Shimels Alem  [no sp found] stored procedure.


    public class proctblFacilityGISLayerUpdateHandler : IRequestHandler<proctblFacilityGISLayerUpdateCommand, IList<tblFacilityGISLayer_Facility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityGISLayerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacilityGISLayer_Facility_id>> Handle( proctblFacilityGISLayerUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblFacilityGISLayer_Facility_id> result = await _procedureAdabter
                .Execute<tblFacilityGISLayer_Facility_id>("[ProprtyData].[no sp found]", request);
           

            return result;
        }
    }
}
 