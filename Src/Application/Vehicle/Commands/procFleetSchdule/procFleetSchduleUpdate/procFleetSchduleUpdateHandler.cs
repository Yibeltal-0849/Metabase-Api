

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;



namespace Application.Vehicle.Commands.procFleetSchdule.procFleetSchduleUpdate.procFleetSchduleUpdateCommand
{

    /// @author  Shimels Alem  proc_Fleet_SchduleUpdate stored procedure.


    public class procFleetSchduleUpdateHandler : IRequestHandler<procFleetSchduleUpdateCommand, IList<FleetSchdule_Fleet_SchduleID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFleetSchduleUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FleetSchdule_Fleet_SchduleID>> Handle( procFleetSchduleUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FleetSchdule_Fleet_SchduleID> result = await _procedureAdabter
                .Execute<FleetSchdule_Fleet_SchduleID>("[Vehicle].proc_Fleet_SchduleUpdate", request);
           

            return result;
        }
    }
}
 