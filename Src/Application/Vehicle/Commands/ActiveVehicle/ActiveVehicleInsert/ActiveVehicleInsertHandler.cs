using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.ActiveVehicle.ActiveVehicleInsert.ActiveVehicleInsertCommand
{ 
	 
      public class ActiveVehicleInsertHandler : IRequestHandler<ActiveVehicleInsertCommand, IList<ActiveVehicle_ActiveVehicle_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ActiveVehicleInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ActiveVehicle_ActiveVehicle_ID>> Handle( ActiveVehicleInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ActiveVehicle_ActiveVehicle_ID> result = await _procedureAdabter
                .Execute<ActiveVehicle_ActiveVehicle_ID>("[Vehicle].Active_VehicleInsert", request);
           
            return result;
        }
    }
}
 
