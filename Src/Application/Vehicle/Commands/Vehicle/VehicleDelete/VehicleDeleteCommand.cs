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

    ///   @author  Shimels Alem VehicleDelete stored procedure.

    public class VehicleDeleteCommand : IRequest<IList<Vehicle_Vehicle_ID>>
    {
        public Guid Vehicle_ID { get; set; }
    }
		
		 
	}
 
 
