using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleLease.VehicleLeaseInsert.VehicleLeaseInsertCommand
{ 
	 
      public class VehicleLeaseInsertHandler : IRequestHandler<VehicleLeaseInsertCommand, IList<VehicleLease_Vehicle_LeaseID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleLeaseInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleLease_Vehicle_LeaseID>> Handle( VehicleLeaseInsertCommand request, CancellationToken cancellationToken)
        {

        IList<VehicleLease_Vehicle_LeaseID> result = await _procedureAdabter
                .Execute<VehicleLease_Vehicle_LeaseID>("[Vehicle].proc_Vehicle_LeaseInsert", request);
           

            return result;
        }
    }
}
 
