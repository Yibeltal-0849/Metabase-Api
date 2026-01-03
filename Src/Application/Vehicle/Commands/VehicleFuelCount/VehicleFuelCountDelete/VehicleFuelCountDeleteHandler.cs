using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleFuelCount.VehicleFuelCountDelete.VehicleFuelCountDeleteCommand
{ 	 
	 
      public class VehicleFuelCountDeleteHandler : IRequestHandler<VehicleFuelCountDeleteCommand, IList<VehicleFuelCount_Vehicle_CountID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleFuelCountDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleFuelCount_Vehicle_CountID>> Handle( VehicleFuelCountDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleFuelCount_Vehicle_CountID> result = await _procedureAdabter
                .Execute<VehicleFuelCount_Vehicle_CountID>("[Vehicle].Vehicle_FuelCountDelete", request);
           

            return result;
        }
    }
}
 
