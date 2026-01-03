using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.procFleetSchdule.procFleetSchduleDelete.procFleetSchduleDeleteCommand
{

    /// @author  Shimels Alem  proc_Fleet_SchduleDelete stored procedure.


    public class procFleetSchduleDeleteHandler : IRequestHandler<procFleetSchduleDeleteCommand, IList<FleetSchdule_Fleet_SchduleID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFleetSchduleDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FleetSchdule_Fleet_SchduleID>> Handle( procFleetSchduleDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FleetSchdule_Fleet_SchduleID> result = await _procedureAdabter
                .Execute<FleetSchdule_Fleet_SchduleID>("[Vehicle].proc_Fleet_SchduleDelete", request);
           

            return result;
        }
    }
}
  