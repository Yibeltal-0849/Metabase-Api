

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblZones.proctblZonesUpdate.proctblZonesUpdateCommand
{

    /// @author  Shimels Alem  proc_tblZonesUpdate stored procedure.


    public class proctblZonesUpdateHandler : IRequestHandler<proctblZonesUpdateCommand, IList<tblZones_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblZonesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblZones_id>> Handle( proctblZonesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblZones_id> result = await _procedureAdabter
                .Execute<tblZones_id>("[ProprtyData].proc_tblZonesUpdate", request);
           

            return result;
        }
    }
}
 