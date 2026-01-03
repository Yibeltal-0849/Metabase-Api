using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleLeaseTo.VehicleLeaseToDelete.VehicleLeaseToDeleteCommand
{

    ///   @author  Shimels Alem Vehicle_LeaseToDelete stored procedure.

    public class VehicleLeaseToDeleteCommand : IRequest<IList<VehicleLeaseTo_Vehicle_LeaseToID>>
    {
        public Guid Vehicle_LeaseToID { get; set; }
    }
		
		 
	}
 
 
