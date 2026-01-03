using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleLeaseTo.VehicleLeaseToUpdate.VehicleLeaseToUpdateCommand
{ 

      public class VehicleLeaseToUpdateHandler : IRequestHandler<VehicleLeaseToUpdateCommand, IList<VehicleLeaseTo_Vehicle_LeaseToID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleLeaseToUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleLeaseTo_Vehicle_LeaseToID>> Handle( VehicleLeaseToUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleLeaseTo_Vehicle_LeaseToID> result = await _procedureAdabter
                .Execute<VehicleLeaseTo_Vehicle_LeaseToID>("[Vehicle].Vehicle_LeaseToUpdate", request);
           

            return result;
        }
    }
}
 
