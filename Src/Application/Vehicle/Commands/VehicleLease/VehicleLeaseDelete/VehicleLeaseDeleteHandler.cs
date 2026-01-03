using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleLease.VehicleLeaseDelete.VehicleLeaseDeleteCommand
{ 	 
	 
      public class VehicleLeaseDeleteHandler : IRequestHandler<VehicleLeaseDeleteCommand, IList<VehicleLease_Vehicle_LeaseID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleLeaseDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleLease_Vehicle_LeaseID>> Handle( VehicleLeaseDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleLease_Vehicle_LeaseID> result = await _procedureAdabter
                .Execute<VehicleLease_Vehicle_LeaseID>("[Vehicle].proc_Vehicle_LeaseDelete", request);
           

            return result;
        }
    }
}
 
