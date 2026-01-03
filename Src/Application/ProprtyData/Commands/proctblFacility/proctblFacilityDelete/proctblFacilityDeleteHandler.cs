using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFacility.proctblFacilityDelete.proctblFacilityDeleteCommand
{

    /// @author  Shimels Alem  proc_tblFacilityDelete stored procedure.


    public class proctblFacilityDeleteHandler : IRequestHandler<proctblFacilityDeleteCommand, IList<tblFacility_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblFacilityDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblFacility_id>> Handle( proctblFacilityDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblFacility_id> result = await _procedureAdabter
                .Execute<tblFacility_id>("[ProprtyData].proc_tblFacilityDelete", request);
           

            return result;
        }
    }
}
  