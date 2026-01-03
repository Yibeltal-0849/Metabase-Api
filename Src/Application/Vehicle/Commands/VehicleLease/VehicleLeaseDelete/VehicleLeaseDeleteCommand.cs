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

    ///   @author  Shimels Alem proc_Vehicle_LeaseDelete stored procedure.

    public class VehicleLeaseDeleteCommand : IRequest<IList<VehicleLease_Vehicle_LeaseID>>
    {
        public Guid Vehicle_LeaseID { get; set; }
    }
		
		 
	}
 
 
