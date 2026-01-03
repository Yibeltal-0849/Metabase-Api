using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.Vehicle.VehicleDelete.VehicleDeleteCommand
{ 	 
	 
      public class VehicleDeleteHandler : IRequestHandler<VehicleDeleteCommand, IList<Vehicle_Vehicle_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Vehicle_Vehicle_ID>> Handle( VehicleDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Vehicle_Vehicle_ID> result = await _procedureAdabter
                .Execute<Vehicle_Vehicle_ID>("[Vehicle].VehicleDelete", request);
           

            return result;
        }
    }
}
 
