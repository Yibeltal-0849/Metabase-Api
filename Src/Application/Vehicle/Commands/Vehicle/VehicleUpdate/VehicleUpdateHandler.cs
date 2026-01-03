using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.Vehicle.VehicleUpdate.VehicleUpdateCommand
{ 

      public class VehicleUpdateHandler : IRequestHandler<VehicleUpdateCommand, IList<Vehicle_Vehicle_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Vehicle_Vehicle_ID>> Handle( VehicleUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Vehicle_Vehicle_ID> result = await _procedureAdabter
                .Execute<Vehicle_Vehicle_ID>("[Vehicle].VehicleUpdate", request);
           

            return result;
        }
    }
}
 
