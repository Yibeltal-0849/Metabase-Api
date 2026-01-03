

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResourceFacility.proctblResourceFacilityUpdate.proctblResourceFacilityUpdateCommand
{

    /// @author  Shimels Alem  [sp not found] stored procedure.


    public class proctblResourceFacilityUpdateHandler : IRequestHandler<proctblResourceFacilityUpdateCommand, IList<tblResourceFacility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceFacilityUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceFacility_id>> Handle( proctblResourceFacilityUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceFacility_id> result = await _procedureAdabter
                .Execute<tblResourceFacility_id>("[ProprtyData].[sp not found]", request);
           

            return result;
        }
    }
}
 