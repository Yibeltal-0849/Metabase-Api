

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblFacility.proctblFacilityUpdate.proctblFacilityUpdateCommand
{

    /// @author  Shimels Alem  proc_tblFacilityUpdate stored procedure.


    public class proctblFacilityUpdateHandler : IRequestHandler<proctblFacilityUpdateCommand, IList<tblFacility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacility_id>> Handle( proctblFacilityUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblFacility_id> result = await _procedureAdabter
                .Execute<tblFacility_id>("[ProprtyData].proc_tblFacilityUpdate", request);
           

            return result;
        }
    }
}
 