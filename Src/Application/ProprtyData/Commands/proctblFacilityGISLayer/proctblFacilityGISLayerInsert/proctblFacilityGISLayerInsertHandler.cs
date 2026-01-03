



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblFacilityGISLayer.proctblFacilityGISLayerInsert.proctblFacilityGISLayerInsertCommand
{

    /// @author  Shimels Alem  proc_tblFacility_GISLayerInsert stored procedure.


    public class proctblFacilityGISLayerInsertHandler : IRequestHandler<proctblFacilityGISLayerInsertCommand, IList<tblFacilityGISLayer_Facility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityGISLayerInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacilityGISLayer_Facility_id>> Handle( proctblFacilityGISLayerInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblFacilityGISLayer_Facility_id> result = await _procedureAdabter
                .Execute<tblFacilityGISLayer_Facility_id>("[ProprtyData].proc_tblFacility_GISLayerInsert", request);
           

            return result;
        }
    }
}
 